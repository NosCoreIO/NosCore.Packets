//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets
{
    public class TypeCreator
    {
        public int PropertyAmount { get; set; }
        public Type? PacketType { get; set; }
        public Delegate? Constructor { get; set; }

        public Dictionary<Tuple<Type, PacketIndexAttribute, string, IEnumerable<ValidationAttribute>>, Delegate> PacketDeserializerDictionary = new Dictionary<Tuple<Type, PacketIndexAttribute, string, IEnumerable<ValidationAttribute>>, Delegate>();

        internal PacketLayout Layout { get; init; } = null!;

        internal Func<object> Create { get; init; } = null!;

        // One per field of the layout, in the same order.
        internal Action<object, object?>[] Setters { get; init; } = Array.Empty<Action<object, object?>>();

        // The first field, and the value a fresh packet holds in it: what this shape claims when it shares its header.
        // The value is read on the first shared-header line rather than at registration, so a getter that cannot
        // run on a fresh packet only fails the lines that need it.
        internal PacketField? FirstField { get; init; }

        internal Lazy<object?> FirstFieldDefault { get; init; } = null!;
    }

    public static class TypeExtension
    {
        private static readonly ConcurrentDictionary<Type, Func<object?>> Defaults = new();

        // Each call gets a box of its own, so a caller mutating a struct default cannot change the next caller's.
        public static object GetDefaultValue(this Type type)
        {
            ArgumentNullException.ThrowIfNull(type);
            return Defaults.GetOrAdd(type, static type => Expression.Lambda<Func<object?>>(
                Expression.Convert(Expression.Default(type), typeof(object))).Compile())()!;
        }

        //https://stackoverflow.com/questions/35913495/moving-from-reflection-to-expression-tree
        public static Func<IEnumerable<object?>, object> GetAndFillListMethod(this Type genericType)
        {
            var listType = typeof(List<>);
            var listGenericType = listType.MakeGenericType(genericType);

            var values = Expression.Parameter(typeof(IEnumerable<object?>), "values");

            var ctor = listGenericType.GetConstructors(BindingFlags.Instance | BindingFlags.Public)
                .OrderBy(x=>x.GetParameters().Length).First();

            var instance = Expression.Variable(listGenericType, "list");

            var parameters = ctor!.GetParameters();
            var parameterExpression = parameters.Select(p => Expression.Default(p.ParameterType)).ToArray();
            var assign = Expression.Assign(instance, Expression.New(ctor, parameterExpression));

            var addMethod = listGenericType.GetMethod("AddRange", new[] { typeof(IEnumerable<>).MakeGenericType(genericType) });

            var castMethod = typeof(Enumerable).GetMethod("Cast", new[] { typeof(IEnumerable) })!.MakeGenericMethod(genericType);

            var castCall = Expression.Call(castMethod, values);
            var addCall = Expression.Call(instance, addMethod!, castCall);

            var block = Expression.Block(
                new[] { instance },
                assign,
                addCall,
                Expression.Convert(instance, typeof(object))
            );

            return (Func<IEnumerable<object?>, object>)Expression.Lambda(block, values).Compile();
        }
    }

    public class Deserializer : IDeserializer
    {
        private readonly Dictionary<string, TypeCreator> _packetDeserializerDictionary = new Dictionary<string, TypeCreator>();
        private readonly Dictionary<string, List<TypeCreator>> _sharedHeaders = new Dictionary<string, List<TypeCreator>>();
        private readonly ConcurrentDictionary<List<TypeCreator>, Serializer> _sharedWriters = new();
        private volatile Dictionary<Type, TypeCreator>? _creatorsByType;

        public Deserializer(IEnumerable<Type> types)
        {
            var deserializerMethod = typeof(Deserializer).GetMethod(nameof(Initialize));
            foreach (var type in types)
            {
                deserializerMethod!.MakeGenericMethod(type).Invoke(this, null);
            }
        }

        public void Initialize<T>() where T : PacketBase
        {
            _creatorsByType = null;
            var headerAttribute = typeof(T).GetCustomAttribute<PacketHeaderAttribute>();
            var header = headerAttribute?.Identification;
            if (_packetDeserializerDictionary.ContainsKey(header ?? typeof(T).Name))
            {
                if (typeof(T).Namespace!.Contains("ServerPackets"))
                {
                    if (headerAttribute?.AllowDuplicateHeader == true
                        && _packetDeserializerDictionary[header!].PacketType!.Namespace!.Contains("ServerPackets"))
                    {
                        if (!_sharedHeaders.TryGetValue(header!, out var shared))
                        {
                            shared = new List<TypeCreator> { _packetDeserializerDictionary[header!] };
                            _sharedHeaders.Add(header!, shared);
                        }

                        shared.Add(CreateTypeCreator<T>());
                    }

                    return;
                }

                _packetDeserializerDictionary.Remove(header ?? typeof(T).Name);
                _sharedHeaders.Remove(header ?? typeof(T).Name);
            }

            var creator = CreateTypeCreator<T>();
            _packetDeserializerDictionary.Add(header ?? typeof(T).Name, creator);
            var aliases = typeof(T).GetCustomAttributes<PacketHeaderAliasAttribute>().Select(s => s.Identification);
            foreach (var alias in aliases)
            {
                if (_packetDeserializerDictionary.ContainsKey(alias) &&
                    _packetDeserializerDictionary[alias].PacketType == creator.PacketType)
                {
                    continue;
                }
                _packetDeserializerDictionary.Add(alias, creator);
            }
        }

        private static TypeCreator CreateTypeCreator<T>() where T : PacketBase
        {
            var layout = PacketLayout.Of(typeof(T));
            var ctor = typeof(T).GetConstructors(BindingFlags.Instance | BindingFlags.Public)
                .OrderBy(x => x.GetParameters().Length).First();
            var create = Expression.Lambda<Func<object>>(Expression.New(ctor,
                ctor.GetParameters().Select(p => Expression.Default(p.ParameterType)))).Compile();

            var setters = new Action<object, object?>[layout.Fields.Length];
            var dictionary = new Dictionary<Tuple<Type, PacketIndexAttribute, string, IEnumerable<ValidationAttribute>>, Delegate>();
            for (var position = 0; position < layout.Fields.Length; position++)
            {
                var field = layout.Fields[position];
                setters[position] = Setter(typeof(T), field.Property);
                dictionary.Add(Tuple.Create(field.Type, field.Index, field.Name, field.Property.GetCustomAttributes(true).OfType<ValidationAttribute>()), setters[position]);
            }

            var first = layout.Fields.FirstOrDefault(field => field.Index.Index == 0);
            return new TypeCreator
            {
                PacketType = typeof(T),
                PropertyAmount = layout.MaxIndex,
                Constructor = create,
                PacketDeserializerDictionary = dictionary,
                Layout = layout,
                Create = create,
                Setters = setters,
                FirstField = first,
                // A getter that failed is tried again on the next line rather than failing every line after it.
                FirstFieldDefault = new Lazy<object?>(() => first?.Property.GetValue(create()), LazyThreadSafetyMode.PublicationOnly),
            };
        }

        private static Action<object, object?> Setter(Type packetType, PropertyInfo property)
        {
            var packet = Expression.Parameter(typeof(object));
            var value = Expression.Parameter(typeof(object));

            // A field computed from the others is read past and not stored.
            if (!property.CanWrite)
            {
                return Expression.Lambda<Action<object, object?>>(Expression.Empty(), packet, value).Compile();
            }

            var type = property.PropertyType;
            // A missing value leaves a value-type field at its default.
            var typed = type.IsValueType
                ? Expression.Condition(Expression.Equal(value, Expression.Constant(null)), Expression.Default(type), Expression.Convert(value, type))
                : (Expression)Expression.Convert(value, type);
            return Expression.Lambda<Action<object, object?>>(
                Expression.Assign(Expression.Property(Expression.Convert(packet, packetType), property), typed),
                packet, value).Compile();
        }

        private TypeCreator? CreatorOf(Type type)
        {
            var creators = _creatorsByType;
            if (creators == null)
            {
                creators = new Dictionary<Type, TypeCreator>();
                foreach (var creator in _packetDeserializerDictionary.Values)
                {
                    creators.TryAdd(creator.PacketType!, creator);
                }

                _creatorsByType = creators;
            }

            return creators.TryGetValue(type, out var found) ? found : null;
        }

        public IPacket Deserialize(string packetContent)
        {
            try
            {
                var isSpecial = false;
                // The header is read with '^' as a space and without the blanks closing the line.
                var packetstring = packetContent.Replace('^', ' ').TrimEnd();
                var position = 0;
                var first = NextField(packetstring, ref position)!;
                var includesKeepAliveIdentity = ushort.TryParse(first, NumberStyles.Integer, CultureInfo.InvariantCulture, out var keepalive);
                var header = includesKeepAliveIdentity ? NextField(packetstring, ref position) ?? throw new InvalidOperationException("A line holds a keep-alive number and no header.") : first;
                // A packet another one carried without its '#' comes back with '^' after its header ("guri^9999").
                var isCaretJoined = position > 0 && packetContent[position - 1] == '^';
                var firstToken = NextField(packetstring, ref position);
                // The body of an unknown line starts after its header as written, '#' included.
                var headerLength = header.Length;
                if (header.Length >= 1 && header[0] is '/' or ':' or ';' or '#')
                {
                    if (header[0] == '#')
                    {
                        isSpecial = true;
                        header = header.Replace("#", "");
                    }
                    else
                    {
                        header = header[0].ToString();
                        headerLength = 1;
                        packetContent = packetContent.Insert(packetContent.IndexOf(header[0]) + 1, " ");
                    }
                }

                if (_packetDeserializerDictionary.TryGetValue(header, out var creator))
                {
                    var content = isSpecial || isCaretJoined ? packetstring : packetContent;
                    var packet = _sharedHeaders.TryGetValue(header, out var shared)
                        ? DeserializeShared(shared, firstToken, content, includesKeepAliveIdentity)
                        : DeserializeIPacket(creator, content, includesKeepAliveIdentity, true);
                    packet!.Header = header;
                    packet!.KeepAliveId = includesKeepAliveIdentity ? keepalive : null;
                    return packet;
                }

                var bodyIndex = (includesKeepAliveIdentity ? first.Length + 2 : 1) + headerLength;
                return new UnresolvedPacket
                {
                    Header = header,
                    KeepAliveId = includesKeepAliveIdentity ? keepalive : null,
                    Body = bodyIndex >= packetContent.Length ? "" : packetContent.Substring(bodyIndex)
                };
            }
            catch (Exception ex)
            {
                var exc = new ArgumentException(null, ex)
                {
                    Data =
                    {
                        ["Packet"] = packetContent
                    }
                };
                throw exc;
            }
        }

        // The next of the line's space-separated fields, or null past the last one.
        private static string? NextField(string line, ref int position)
        {
            if (position < 0)
            {
                return null;
            }

            var end = line.IndexOf(' ', position);
            var field = end < 0 ? line[position..] : line[position..end];
            position = end < 0 ? -1 : end + 1;
            return field;
        }

        // A packet's tokens are the runs of non-blank characters, with an empty token for every further blank
        // between two of them or closing the line ("a  b " is "a", "", "b", ""); a blank opening the line is not one.
        // A carriage return is not a blank: it separates two texts that each keep their spaces (rbr's title and
        // description).
        private static string[] Tokenize(string content)
        {
            var tokens = content.Contains('\r') ? content.Split(BlanksButCarriageReturn) : content.Split((char[]?)null);
            return tokens[0].Length == 0 ? tokens[1..] : tokens;
        }

        private static readonly char[] BlanksButCarriageReturn = Enumerable.Range(0, char.MaxValue + 1)
            .Select(code => (char)code)
            .Where(character => char.IsWhiteSpace(character) && character != '\r')
            .ToArray();

        // The tokens a packet read from the given parts would have, had they been joined with spaces and tokenized.
        private static string[] Tokenize(string[] parts) => parts.Length > 0 && parts[0].Length == 0 ? parts[1..] : parts;

        // Packets sharing a header are told apart by their first field, which each one sets to its own value.
        // Where several share that value too, the one whose reading writes the line back unchanged is the one sent.
        private IPacket? DeserializeShared(List<TypeCreator> shared, string? firstToken, string packetContent, bool includesKeepAliveIdentity)
        {
            var candidates = shared.Where(creator => StartsWith(creator, firstToken)).ToList();
            if (candidates.Count == 0)
            {
                // The shapes that leave their first field at the default read the lines no other shape claims.
                candidates.AddRange(shared.Where(creator => !ClaimsFirstField(creator)));
            }

            if (candidates.Count == 0)
            {
                candidates.Add(shared[0]);
            }

            if (candidates.Count == 1)
            {
                return DeserializeIPacket(candidates[0], packetContent, includesKeepAliveIdentity, true);
            }

            IPacket? readable = null;
            IPacket? writtenBack = null;
            Exception? failure = null;
            foreach (var creator in candidates)
            {
                IPacket? packet;
                try
                {
                    packet = DeserializeIPacket(creator, packetContent, includesKeepAliveIdentity, true);
                }
                catch (Exception ex)
                {
                    failure ??= ex;
                    continue;
                }

                if (packet == null)
                {
                    continue;
                }

                readable ??= packet;
                // Two shapes can write a line back alike; the one whose values its enumerations name is the one sent.
                if (WritesBack(shared, packet, packetContent))
                {
                    if (packet.IsValid)
                    {
                        return packet;
                    }

                    writtenBack ??= packet;
                }
            }

            return writtenBack ?? readable ?? throw failure ?? new InvalidOperationException();
        }

        private static bool StartsWith(TypeCreator creator, string? firstToken)
        {
            var first = creator.FirstField;
            if (first == null || firstToken == null || (!first.IsScalar && first.Type != typeof(string)))
            {
                return false;
            }

            var own = creator.FirstFieldDefault.Value;
            if (first.Type == typeof(string))
            {
                // A text first field claims only the token it holds, even an empty one ("score  5 ...").
                return own is string text && text == firstToken;
            }

            if ((first.Underlying ?? first.Type).IsEnum)
            {
                return Enum.TryParse(first.Underlying ?? first.Type, firstToken, out var parsed) && Equals(own, parsed);
            }

            try
            {
                return Equals(own, DeserializeDefault(first, firstToken));
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static bool ClaimsFirstField(TypeCreator creator) =>
            creator.FirstField is { } first && !Equals(creator.FirstFieldDefault.Value, first.Type.IsValueType ? first.Default : null);

        private bool WritesBack(List<TypeCreator> shared, IPacket packet, string packetContent)
        {
            var writer = _sharedWriters.GetOrAdd(shared, s => new Serializer(s.Select(c => c.PacketType!)));
            try
            {
                return string.Equals(writer.Serialize(packet), packetContent.TrimEnd(), StringComparison.Ordinal);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private IPacket DeserializeIPacket(TypeCreator dic, string packetContent, bool includesKeepAliveIdentity, bool hasHeader) =>
            DeserializeIPacket(dic, Tokenize(packetContent), (hasHeader ? 1 : 0) + (includesKeepAliveIdentity ? 1 : 0), hasHeader);

        private IPacket DeserializeIPacket(TypeCreator dic, string[] tokens, int start, bool hasHeader)
        {
            var matches = tokens;
            var position = start;
            try
            {
                return DeserializeFields(dic, ref matches, ref position, hasHeader, inLine: false, lastInLine: true);
            }
            catch (Exception) when (hasHeader)
            {
                // An optional field ahead of the last one can be left out of the line entirely; when reading it
                // shifts every later field off its type, the line is read again without it.
                foreach (var optional in dic.Layout.LeftOutCandidates)
                {
                    try
                    {
                        var retry = tokens;
                        var retryStart = start;
                        return DeserializeFields(dic, ref retry, ref retryStart, hasHeader, inLine: false,
                            lastInLine: true, leftOut: optional);
                    }
                    catch (Exception)
                    {
                        // the next optional field is tried
                    }
                }

                throw;
            }
        }

        // Reads a packet's fields from the tokens at a position. A sub-packet written with spaces between its
        // fields is read inLine, from its parent's own tokens, so whatever its fields span is consumed.
        private IPacket DeserializeFields(TypeCreator dic, ref string[] matches, ref int start, bool hasHeader, bool inLine, bool lastInLine, string? leftOut = null)
        {
            var deg = (IPacket)dic.Create();
            var fields = dic.Layout.Fields;
            if (matches.Length == 0 || fields.Length == 0)
            {
                return deg;
            }

            var trueIndex = -1;
            var absent = -1;
            for (var position = 0; position < fields.Length; position++)
            {
                var field = fields[position];
                var set = dic.Setters[position];
                if (field.Name == leftOut)
                {
                    if (field.AcceptsNull)
                    {
                        set(deg, null);
                    }

                    continue;
                }

                if (position == absent || field.PresentWhen?.Holds(deg) == false)
                {
                    continue;
                }

                var isMaxIndex = field.Index.Index == dic.Layout.MaxIndex && lastInLine;
                var currentIndex = inLine ? start + position : field.Index.Index + start;
                trueIndex = trueIndex == -1 ? (inLine ? start : currentIndex) : trueIndex;

                // An optional field is left out when the rest of the line only holds the required fields after it.
                if (field.Index.IsOptional && field.RequiredAfter > 0 && lastInLine && matches.Length - trueIndex <= field.RequiredAfter)
                {
                    if (field.AcceptsNull)
                    {
                        set(deg, null);
                    }

                    continue;
                }

                if (trueIndex < matches.Length)
                {
                    if (matches[trueIndex].Length == 0 && field.IsScalar)
                    {
                        trueIndex++;
                        continue;
                    }

                    // A field written with its own separator rides on the token before it ("familyId.title");
                    // when it is left out, the token has no separator and the field reads as absent.
                    if ((hasHeader || inLine) && position + 1 < fields.Length && fields[position + 1].JoinedSeparator is { } joinedSeparator)
                    {
                        var at = matches[trueIndex].IndexOf(joinedSeparator, StringComparison.Ordinal);
                        if (at < 0)
                        {
                            absent = position + 1;
                        }
                        else
                        {
                            matches = SplitToken(matches, trueIndex, at, joinedSeparator.Length);
                        }
                    }

                    var value = field.FreeTextWhen?.Holds(deg) == true
                        ? ReadFreeText(matches, ref trueIndex)
                        : DeserializeValue(field, ref matches, ref trueIndex, isMaxIndex, field.RequiredAfter);

                    set(deg, value);
                }
                else if (isMaxIndex && field.Type == typeof(string))
                {
                    // Null even where the property is not nullable: that is what makes validation reject a line
                    // missing a required name.
                    set(deg, null);
                }
                else if (field.Index.IsOptional && field.Underlying != null)
                {
                    set(deg, null);
                }
                else
                {
                    break;
                }
            }

            if (inLine)
            {
                start = Math.Max(trueIndex, start);
            }

            return deg;
        }

        private static string[] SplitToken(string[] matches, int index, int at, int separatorLength)
        {
            var split = new string[matches.Length + 1];
            Array.Copy(matches, split, index);
            split[index] = matches[index][..at];
            split[index + 1] = matches[index][(at + separatorLength)..];
            Array.Copy(matches, index + 1, split, index + 2, matches.Length - index - 1);
            return split;
        }

        // The blanks the server leaves at the end of the line are not part of the text.
        private static Game18NArguments ReadFreeText(string[] matches, ref int currentIndex)
        {
            var text = string.Join(' ', matches, currentIndex, matches.Length - currentIndex).TrimEnd();
            currentIndex = matches.Length;
            return new Game18NArguments(1) { text };
        }

        private object? DeserializeValue(PacketField field, ref string[] matches, ref int currentIndex, bool isMaxIndex, int reserved)
        {
            switch (field.Kind)
            {
                case FieldKind.Text:
                    var text = DeserializeString(matches, ref currentIndex, isMaxIndex);
                    return field.Index.EscapeSpaces && text is string escaped
                        ? escaped.Replace(field.Index.SpaceEscape, " ", StringComparison.Ordinal)
                        : text;
                case FieldKind.Guid:
                    var guid = matches[currentIndex++];
                    return guid == "NONE" ? null : Guid.Parse(guid);
                case FieldKind.Boolean:
                    var boolean = matches[currentIndex++];
                    return boolean == "-1" ? null : boolean == "1";
                case FieldKind.Enumeration:
                    return DeserializeEnum(field, matches[currentIndex++]);
                case FieldKind.Arguments:
                    // Game18NArguments is a non-generic IList<object> holding the rest of the line: numeric tokens
                    // go in as long, the others as string.
                    var argumentCount = field.Index is PacketListIndexAttribute { Length: > 0 } fixedLength
                        ? Math.Min((int)fixedLength.Length, matches.Length - currentIndex)
                        : matches.Length - currentIndex;
                    var g18n = new Game18NArguments(Math.Max(1, argumentCount));
                    var argumentEnd = currentIndex + argumentCount;
                    while (currentIndex < argumentEnd)
                    {
                        var token = matches[currentIndex++];
                        g18n.Add(long.TryParse(token, NumberStyles.Integer, CultureInfo.InvariantCulture, out var longValue) ? longValue : token);
                    }
                    return g18n;
                case FieldKind.Array:
                    var items = DeserializeList(field, matches, ref currentIndex, isMaxIndex, reserved) as IList;
                    var array = Array.CreateInstance(field.ElementType!, items?.Count ?? 0);
                    items?.CopyTo(array, 0);
                    return array;
                case FieldKind.List:
                    if (field.ElementType == null)
                    {
                        throw new InvalidOperationException($"{field.Name} is a collection with no element type.");
                    }

                    return DeserializeList(field, matches, ref currentIndex, isMaxIndex, reserved);
                case FieldKind.AnyPacket when field.Index.RemoveHash && isMaxIndex:
                    var inlinePacket = string.Join(' ', matches, currentIndex, matches.Length - currentIndex);
                    currentIndex = matches.Length;
                    return Deserialize(inlinePacket);
                case FieldKind.AnyPacket:
                    var embedded = matches[currentIndex++];
                    if (embedded.StartsWith('#'))
                    {
                        return Deserialize(embedded);
                    }

                    // Its fields are still joined with '^'.
                    var bare = Deserialize($"#{embedded}");
                    if (bare is PacketBase written)
                    {
                        written.IsWrittenWithoutHash = true;
                    }

                    return bare;
                case FieldKind.SubPacket:
                    return DeserializeSubPacket(field, ref matches, ref currentIndex, isMaxIndex);
                // An optional field that is null is left off the line, so a -1 there is the value itself.
                case FieldKind.Value when field.Index.IsOptional && matches[currentIndex] == "-1"
                    && field.Underlying is { IsPrimitive: true } underlying:
                    currentIndex++;
                    return Convert.ChangeType(-1, underlying, CultureInfo.InvariantCulture);
                default:
                    return DeserializeDefault(field, matches[currentIndex++]);
            }
        }

        private IPacket? DeserializeSubPacket(PacketField field, ref string[] matches, ref int currentIndex, bool isMaxIndex)
        {
            // A field typed with a family of packets sharing one header (e_info) has nothing to say which
            // one it holds, so it is skipped rather than read as the wrong one.
            if ((CreatorOf(field.Type) ?? (_packetDeserializerDictionary.TryGetValue(field.Type.Name, out var named) ? named : null)) is not { } dic)
            {
                currentIndex++;
                return null;
            }

            var layout = field.Layout;
            var subPacketSeparator = field.SubPacketSeparator;
            // The serializer joins a header-less sub-packet's fields with spaces unless it names a separator;
            // a client line can still join them with dots.
            if (subPacketSeparator == " " || (subPacketSeparator == null && !layout.HasHeader
                && !(currentIndex < matches.Length && layout.IsJoined(matches[currentIndex], "."))))
            {
                if (field.Index.IsOptional && (currentIndex >= matches.Length || matches[currentIndex].Length == 0))
                {
                    return null;
                }

                return DeserializeFields(dic, ref matches, ref currentIndex, hasHeader: false, inLine: true, lastInLine: isMaxIndex);
            }

            // Texts joined by a separator that is not a space, ending the line, each keep their spaces.
            var joinedTexts = isMaxIndex && !layout.HasHeader && subPacketSeparator is { Length: > 0 }
                && subPacketSeparator.All(char.IsWhiteSpace) && subPacketSeparator != " ";

            // An absent sub-packet is written as a lone -1 in place of its joined fields; joined texts are absent
            // only when the -1 is all that is left of the line, since a text may itself start with -1.
            if (subPacketSeparator is { Length: > 0 } && matches[currentIndex] == "-1" && layout.Fields.Length > 1
                && (!joinedTexts || currentIndex == matches.Length - 1))
            {
                currentIndex++;
                return null;
            }

            if (joinedTexts)
            {
                var texts = string.Join(' ', matches, currentIndex, matches.Length - currentIndex)
                    .Split(subPacketSeparator, layout.Fields.Length);
                currentIndex = matches.Length;
                return DeserializeIPacket(dic, texts, 0, false);
            }

            var subPacketContent = matches[currentIndex].Replace(subPacketSeparator ?? (layout.HasHeader ? "^" : "."), " ");
            // A value field with its own separator ("vnum.current/total") is split on that one too.
            foreach (var fieldSeparator in layout.ValueSeparators)
            {
                subPacketContent = subPacketContent.Replace(fieldSeparator, " ");
            }

            var packet = DeserializeIPacket(dic, subPacketContent, false, false);
            currentIndex++;
            return packet;
        }

        private object? DeserializeList(PacketField field, string[] matches, ref int currentIndex, bool isMaxIndex, int reserved)
        {
            var subType = field.ElementType!;
            var packetIndexAttribute = field.Index;
            var isPacketList = typeof(IPacket).IsAssignableFrom(subType);
            var listSeparator = packetIndexAttribute.SpecialSeparator ?? ".";
            var length = packetIndexAttribute is PacketListIndexAttribute listIndex ? listIndex.Length : 0;
            var untilLastToken = false;
            var lastToken = matches.Length;
            string[]? splited = null;

            if (length < 0)
            {
                length = int.Parse(matches[currentIndex + length], NumberStyles.Integer, CultureInfo.InvariantCulture);
            }
            else
            {
                var separator = packetIndexAttribute.SpecialSeparator;
                if (packetIndexAttribute is PacketListIndexAttribute ind)
                {
                    // For sub-packet lists, SpecialSeparator names the separator inside each sub-packet, and the
                    // items are tokenised by the outer packet's whitespace unless ListSeparator names another. For
                    // value lists, SpecialSeparator is the item separator, "." by default.
                    separator = ind.ListSeparator ?? (isPacketList ? null : separator ?? ".");
                }

                if (separator?.Length == 0)
                {
                    // A list written with no separator holds one character per item ("011").
                    splited = matches[currentIndex].Select(character => character.ToString()).ToArray();
                    length = splited.Length;
                }
                else if (isMaxIndex && string.IsNullOrWhiteSpace(separator))
                {
                    // A client line can end with a space, which would otherwise read as one more empty item.
                    while (lastToken > currentIndex && matches[lastToken - 1].Length == 0)
                    {
                        lastToken--;
                    }

                    // Sub-packets whose fields are space-separated span several tokens each (exc_list's "type slot
                    // amount"), and an absent one only its "-1", so the items run to the end of the line.
                    untilLastToken = isPacketList;
                    length = lastToken - currentIndex;
                }

                if (!string.IsNullOrWhiteSpace(separator))
                {
                    splited = matches[currentIndex].Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    length = splited.Length;
                }
                else if (length == 0 && !isMaxIndex && separator == null && isPacketList)
                {
                    // A list followed by other fields runs while its items look like this sub-packet, or are
                    // the "-1" of an empty entry.
                    var end = currentIndex;
                    while (end < matches.Length
                        && (matches[end] == "-1" || field.ElementLayout.IsJoined(matches[end], listSeparator)))
                    {
                        end++;
                    }

                    length = end - currentIndex;
                }
                else if (length == 0 && !isMaxIndex && separator == " ")
                {
                    // A space-separated list followed by other fields leaves their tokens to them; a list of values
                    // also stops at the first token that is not one.
                    var available = matches.Length - currentIndex - reserved;
                    if (isPacketList)
                    {
                        var subPacketCreator = CreatorOf(subType);
                        length = subPacketCreator == null ? 0 : Math.Max(0, available / subPacketCreator.Layout.TokenSpan);
                    }
                    else
                    {
                        var end = currentIndex;
                        while (end < currentIndex + available && long.TryParse(matches[end], NumberStyles.Integer, CultureInfo.InvariantCulture, out _))
                        {
                            end++;
                        }

                        length = end - currentIndex;
                    }
                }
            }

            if (length <= 0)
            {
                return null;
            }

            // A count is read from the line, so it never reserves more than the line can hold.
            var list = new List<object?>(Math.Min(length, splited?.Length ?? Math.Max(0, matches.Length - currentIndex)));
            if (isPacketList)
            {
                ReadPackets(field, list, splited, matches, ref currentIndex, length, untilLastToken ? lastToken : -1);
            }
            else
            {
                for (var i = 0; i < length; i++)
                {
                    var value = long.Parse(splited != null ? splited[i] : matches[currentIndex + i], NumberStyles.Integer, CultureInfo.InvariantCulture);
                    list.Add(value == -1 ? null : Convert.ChangeType(value, Nullable.GetUnderlyingType(subType) ?? subType, CultureInfo.InvariantCulture));
                }

                currentIndex += splited != null ? 1 : length;
            }

            return field.FillList(list);
        }

        // Reads a list's sub-packets: one per part of the token when the list has its own separator, otherwise from
        // the line's tokens, where an item is its "-1" when absent, one token when its fields are joined, or one
        // token per field. With lastToken set, the items run to that token rather than to a count.
        private void ReadPackets(PacketField field, List<object?> list, string[]? splited, string[] matches, ref int currentIndex,
            int length, int lastToken)
        {
            var listSeparator = field.Index.SpecialSeparator ?? ".";
            if (CreatorOf(field.ElementType!) is not { } creator)
            {
                currentIndex += splited != null ? 1 : 0;
                return;
            }

            var position = currentIndex;
            for (var i = 0; lastToken >= 0 ? position < lastToken : i < length; i++)
            {
                // A count can promise more items than the line holds.
                if (splited == null && position >= matches.Length)
                {
                    break;
                }

                var token = splited != null ? splited[i] : matches[position];
                string[] tokens;
                if (token == "-1")
                {
                    list.Add(null);
                    position++;
                    continue;
                }

                if (splited != null || field.ElementLayout.IsJoined(token, listSeparator))
                {
                    tokens = field.ElementLayout.IsJoined(token, listSeparator)
                        ? SplitJoined(token, creator.Layout, listSeparator)
                        : Tokenize(new[] { token });
                    position++;
                }
                else
                {
                    var itemEnd = Math.Min(position + creator.Layout.TokenSpan, matches.Length);
                    tokens = Tokenize(matches[position..itemEnd]);
                    position = itemEnd;
                    // Read in line so that a field joined to the one before it is split off its token.
                    var start = 0;
                    list.Add(DeserializeFields(creator, ref tokens, ref start, hasHeader: false, inLine: true, lastInLine: true));
                    continue;
                }

                list.Add(DeserializeIPacket(creator, tokens, 0, false));
            }

            currentIndex = splited != null ? currentIndex + 1 : position;
        }

        // Splits a sub-packet written as one token into a token per field. When the line carries fewer fields
        // than the class, the optional ones are the ones left out, latest first, and read as absent.
        private static string[] SplitJoined(string token, PacketLayout layout, string listSeparator)
        {
            var fields = layout.Fields;
            var parts = new List<string>(fields.Length);
            var rest = token;
            for (var index = 1; index < fields.Length; index++)
            {
                var separator = fields[index].Index.SpecialSeparator ?? listSeparator;
                var at = separator.Length == 0 ? -1 : rest.IndexOf(separator, StringComparison.Ordinal);
                if (at < 0)
                {
                    break;
                }

                parts.Add(rest[..at]);
                rest = rest[(at + separator.Length)..];
            }

            parts.Add(rest);
            var absent = 0;
            var absentFrom = fields.Length;
            for (var index = fields.Length - 1; index >= 0 && fields.Length - absent > parts.Count; index--)
            {
                if (fields[index].Index.IsOptional)
                {
                    absent++;
                    absentFrom = index;
                }
            }

            var tokens = new List<string>(fields.Length);
            var next = 0;
            for (var index = 0; index < fields.Length && next < parts.Count; index++)
            {
                tokens.Add(index >= absentFrom && fields[index].Index.IsOptional
                    ? fields[index].Type == typeof(string) ? "-" : string.Empty
                    : parts[next++]);
            }

            return Tokenize(tokens.ToArray());
        }

        private static object? DeserializeEnum(PacketField field, string value) =>
            (value == "-1" && field.MinusOneIsDefault) || IsAbsentOptional(field, value)
                ? field.Default
                : Enum.Parse(field.Underlying ?? field.Type, value);

        // The client ends some packets with a separator, which leaves an empty last field.
        private static bool IsAbsentOptional(PacketField field, string value) =>
            value.Length == 0 && field.Underlying != null;

        private static object? DeserializeDefault(PacketField field, string value) =>
            (value == "-1" && !field.Type.IsPrimitive) || IsAbsentOptional(field, value)
                ? field.Default
                : Convert.ChangeType(value, field.Underlying ?? field.Type, CultureInfo.InvariantCulture);

        private static string? DeserializeString(string[] matches, ref int currentIndex, bool isMaxIndex)
        {
            if (isMaxIndex)
            {
                var rest = string.Join(' ', matches, currentIndex, matches.Length - currentIndex);
                currentIndex = matches.Length - 1;
                return rest;
            }

            if (matches[currentIndex] == "-")
            {
                currentIndex++;
                return null;
            }

            return matches[currentIndex++];
        }
    }
}
