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
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
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
    }

    //TODO make those expression tree cached
    public static class TypeExtension
    {
        public static object GetDefaultValue(this Type type)
        {
            if (type == null) throw new ArgumentNullException("type");
            var e = Expression.Lambda<Func<object>>(
                Expression.Convert(
                    Expression.Default(type), typeof(object)
                )
            );

            return e.Compile()();
        }

        //https://stackoverflow.com/questions/35913495/moving-from-reflection-to-expression-tree
        public static Func<IEnumerable<object?>, object> GetAndFillListMethod(this Type genericType)
        {
            var listType = typeof(List<>);
            var listGenericType = listType.MakeGenericType(genericType);

            var values = Expression.Parameter(typeof(IEnumerable<object?>), "values");

            var ctor = listGenericType.GetConstructors(BindingFlags.Instance | BindingFlags.Public)
                .OrderBy(x=>x.GetParameters().Length).First();

            // I prefer using Expression.Variable to Expression.Parameter
            // for internal variables
            var instance = Expression.Variable(listGenericType, "list");

            var parameters = ctor!.GetParameters();
            var parameterExpression = parameters.Select(p => Expression.Default(p.ParameterType)).ToArray();
            var assign = Expression.Assign(instance, Expression.New(ctor, parameterExpression));

            var addMethod = listGenericType.GetMethod("AddRange", new[] { typeof(IEnumerable<>).MakeGenericType(genericType) });

            // Enumerable.Cast<T>
            var castMethod = typeof(Enumerable).GetMethod("Cast", new[] { typeof(IEnumerable) })!.MakeGenericMethod(genericType);

            // For the parameters there is a params Expression[], so no explicit array necessary
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
        private readonly ConcurrentDictionary<Type, Func<IEnumerable<object?>, object>> _getAndFillListMethods;
        private readonly Dictionary<string, TypeCreator> _packetDeserializerDictionary = new Dictionary<string, TypeCreator>();
        private readonly Dictionary<string, List<TypeCreator>> _sharedHeaders = new Dictionary<string, List<TypeCreator>>();

        public Deserializer(IEnumerable<Type> types)
        {
            _getAndFillListMethods = new ConcurrentDictionary<Type, Func<IEnumerable<object?>, object>>();
            var deserializerMethod = typeof(Deserializer).GetMethod(nameof(Initialize));
            foreach (var type in types)
            {
                deserializerMethod!.MakeGenericMethod(type).Invoke(this, null);
            }
        }

        public void Initialize<T>() where T : PacketBase
        {
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

        private TypeCreator CreateTypeCreator<T>() where T : PacketBase
        {
            var types = typeof(T).GetProperties()
                    .Where(x => x.GetCustomAttributes(true).OfType<PacketIndexAttribute>().Any()).ToList();
            var propertyAmount = types.Any() ? types.Max(x => x.GetCustomAttributes(true).OfType<PacketIndexAttribute>().First().Index) : 0;

            var ctor = typeof(T).GetConstructors(BindingFlags.Instance | BindingFlags.Public)
                .OrderBy(x => x.GetParameters().Length).First();

            var parameters = ctor.GetParameters();
            var parameterExpression = parameters.Select(p => Expression.Default(p.ParameterType)).ToArray();


            return new TypeCreator
            {
                PacketType = typeof(T),
                PropertyAmount = propertyAmount,
                Constructor = Expression.Lambda(Expression.New(ctor, parameterExpression)).Compile(),
                PacketDeserializerDictionary = GeneratePacketDeserializerDictionary(typeof(T))
            };
        }

        private Delegate GetPropSetter(Type typeObj, Type typeProperty, string propertyName)
        {
            var paramExpression = Expression.Parameter(typeObj);

            var paramExpression2 = Expression.Parameter(typeProperty, propertyName);

            var propertyGetterExpression = Expression.Property(paramExpression, propertyName);

            return Expression.Lambda
            (
                Expression.Assign(propertyGetterExpression, paramExpression2), paramExpression, paramExpression2
            ).Compile();
        }

        private Dictionary<Tuple<Type, PacketIndexAttribute, string, IEnumerable<ValidationAttribute>>, Delegate> GeneratePacketDeserializerDictionary(Type type)
        {
            var dic = new Dictionary<Tuple<Type, PacketIndexAttribute, string, IEnumerable<ValidationAttribute>>, Delegate>();
            var properties = type.GetProperties()
                .Where(x => x.GetCustomAttributes(true).OfType<PacketIndexAttribute>().Any())
                .OrderBy(x => x.GetCustomAttributes(true).OfType<PacketIndexAttribute>().First().Index).ToList();
            foreach (var packetBasePropertyInfo in properties)
            {
                var packetIndex = packetBasePropertyInfo.GetCustomAttributes(true).OfType<PacketIndexAttribute>()
                    .First();
                var packetValidators = packetBasePropertyInfo.GetCustomAttributes(true).OfType<ValidationAttribute>();

                dic.Add(new Tuple<Type, PacketIndexAttribute, string, IEnumerable<ValidationAttribute>>(packetBasePropertyInfo.PropertyType, packetIndex, packetBasePropertyInfo.Name, packetValidators), GetPropSetter(type, packetBasePropertyInfo.PropertyType, packetBasePropertyInfo.Name));
            }

            return dic;
        }

        public IPacket Deserialize(string packetContent)
        {
            try
            {
                var isSpecial = false;
                var packetstring = packetContent.Replace('^', ' ').TrimEnd();
                var packetsplit = packetstring.Split(' ');
                if (packetsplit.Length < 1)
                {
                    throw new InvalidOperationException();
                }

                var includesKeepAliveIdentity = ushort.TryParse(packetsplit[0], out var keepalive);
                var header = includesKeepAliveIdentity ? 1 : 0;
                if (packetsplit[header].Length >= 1
                    && (packetsplit[header][0] == '/' || packetsplit[header][0] == ':' || packetsplit[header][0] == ';' || packetsplit[header][0] == '#'))
                {
                    if (packetsplit[header][0] == '#')
                    {
                        isSpecial = true;
                        packetsplit[header] = packetsplit[header].Replace("#", "");
                    }
                    else
                    {
                        packetsplit[header] = packetsplit[header][0].ToString();
                        packetContent = packetContent.Insert(packetContent.IndexOf(packetsplit[header][0]) + 1, " ");
                    }
                }

                if (_packetDeserializerDictionary.ContainsKey(packetsplit[header]))
                {
                    var content = isSpecial ? packetstring : packetContent;
                    var packet = _sharedHeaders.TryGetValue(packetsplit[header], out var shared)
                        ? DeserializeShared(shared, packetsplit.Length > header + 1 ? packetsplit[header + 1] : null, content, includesKeepAliveIdentity)
                        : DeserializeIPacket(_packetDeserializerDictionary[packetsplit[header]], content, includesKeepAliveIdentity, true);
                    packet!.Header = packetsplit[header];
                    packet!.KeepAliveId = includesKeepAliveIdentity ? (ushort?)keepalive : null;
                    return packet;
                }

                var bodyIndex = (includesKeepAliveIdentity ? packetsplit[0].Length + 2 : 1) + (includesKeepAliveIdentity ? packetsplit[1].Length : packetsplit[0].Length);
                return new UnresolvedPacket
                {
                    Header = packetsplit[header],
                    KeepAliveId = includesKeepAliveIdentity ? (ushort?)ushort.Parse(packetsplit[0]) : null,
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

        // Packets sharing a header are told apart by their first field, which each one sets to its own value.
        // Where several share that value too, the one whose reading writes the line back unchanged is the one sent.
        private IPacket? DeserializeShared(List<TypeCreator> shared, string? firstToken, string packetContent, bool includesKeepAliveIdentity)
        {
            var candidates = shared.Where(creator => StartsWith(creator, firstToken)).ToList();
            if (candidates.Count == 0)
            {
                candidates.Add(shared[0]);
            }

            if (candidates.Count == 1)
            {
                return DeserializeIPacket(candidates[0], packetContent, includesKeepAliveIdentity, true);
            }

            IPacket? readable = null;
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
                if (WritesBack(shared, packet, packetContent))
                {
                    return packet;
                }
            }

            return readable ?? throw failure ?? new InvalidOperationException();
        }

        private bool StartsWith(TypeCreator creator, string? firstToken)
        {
            var first = creator.PacketDeserializerDictionary.Keys.FirstOrDefault(s => s.Item2.Index == 0);
            if (first == null || firstToken == null || !IsScalar(first.Item1))
            {
                return false;
            }

            var own = creator.PacketType!.GetProperty(first.Item3)!.GetValue(creator.Constructor!.DynamicInvoke());
            try
            {
                var type = Nullable.GetUnderlyingType(first.Item1) ?? first.Item1;
                return Equals(own, type.IsEnum ? Enum.Parse(type, firstToken) : DeserializeDefault(first.Item1, firstToken));
            }
            catch (Exception)
            {
                return false;
            }
        }

        private readonly ConcurrentDictionary<List<TypeCreator>, Serializer> _sharedWriters = new();

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

        private IPacket? DeserializeIPacket(TypeCreator dic, string packetContent, bool includesKeepAliveIdentity, bool hasHeader)
        {
            var matches = Regex.Matches(packetContent, @"([^\s\v]+)|(?<=\s)(?=\s|$)")
                .Select(s => s.Value).ToArray();
            var start = (hasHeader ? 1 : 0) + (includesKeepAliveIdentity ? 1 : 0);
            var tokens = matches;
            try
            {
                return DeserializeFields(dic, ref matches, ref start, hasHeader, inLine: false, lastInLine: true);
            }
            catch (Exception) when (hasHeader)
            {
                // An optional field ahead of the last one can be left out of the line entirely; when reading it
                // shifts every later field off its type, the line is read again without it.
                var properties = dic.PacketDeserializerDictionary.Keys.ToList();
                var maxindex = properties.Max(s => s.Item2.Index);
                foreach (var optional in properties.Where(s => s.Item2.IsOptional && s.Item2.Index != maxindex
                             && IsScalar(s.Item1)))
                {
                    try
                    {
                        var retry = tokens;
                        var retryStart = start;
                        return DeserializeFields(dic, ref retry, ref retryStart, hasHeader, inLine: false,
                            lastInLine: true, leftOut: optional.Item3);
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
            var deg = (IPacket)dic.Constructor!.DynamicInvoke()!;
            if (matches.Length > 0 && dic.PacketDeserializerDictionary.Count > 0)
            {
                var maxindex = dic.PacketDeserializerDictionary.Max(s => s.Key.Item2.Index);
                var trueIndex = -1;
                var properties = dic.PacketDeserializerDictionary.ToList();
                var absent = -1;
                for (var position = 0; position < properties.Count; position++)
                {
                    var packetBasePropertyInfo = properties[position];
                    if (packetBasePropertyInfo.Key.Item3 == leftOut)
                    {
                        if (Nullable.GetUnderlyingType(packetBasePropertyInfo.Key.Item1) != null
                            || !packetBasePropertyInfo.Key.Item1.IsValueType)
                        {
                            packetBasePropertyInfo.Value.DynamicInvoke(deg, null);
                        }

                        continue;
                    }

                    if (position == absent || !IsPresent(dic.PacketType!, packetBasePropertyInfo.Key.Item3, deg))
                    {
                        continue;
                    }

                    var isMaxIndex = packetBasePropertyInfo.Key.Item2.Index == maxindex && lastInLine;
                    var currentIndex = inLine ? start + position : packetBasePropertyInfo.Key.Item2.Index + start;
                    trueIndex = trueIndex == -1 ? (inLine ? start : currentIndex) : trueIndex;
                    if (trueIndex < matches.Length)
                    {
                        if (trueIndex < matches.Length && matches[trueIndex].Length == 0 && IsScalar(packetBasePropertyInfo.Key.Item1))
                        {
                            trueIndex++;
                            continue;
                        }

                        // A field written with its own separator rides on the token before it ("familyId.title");
                        // when it is left out, the token has no separator and the field reads as absent.
                        if ((hasHeader || inLine) && position + 1 < properties.Count && trueIndex < matches.Length
                            && JoinedSeparator(properties[position + 1].Key) is { } joinedSeparator)
                        {
                            var at = matches[trueIndex].IndexOf(joinedSeparator, StringComparison.Ordinal);
                            if (at < 0)
                            {
                                absent = position + 1;
                            }
                            else
                            {
                                matches = matches.Take(trueIndex)
                                    .Append(matches[trueIndex][..at])
                                    .Append(matches[trueIndex][(at + joinedSeparator.Length)..])
                                    .Concat(matches.Skip(trueIndex + 1))
                                    .ToArray();
                            }
                        }

                        var reserved = properties.Skip(position + 1).Count(later => !later.Key.Item2.IsOptional);
                        var value = DeserializeValue(packetBasePropertyInfo.Key, packetBasePropertyInfo.Key.Item1,
                            ref matches, ref trueIndex, isMaxIndex, reserved);

                        packetBasePropertyInfo.Value.DynamicInvoke(deg, value);
                    }
                    else if (isMaxIndex && packetBasePropertyInfo.Key.Item1 == typeof(string))
                    {
                        packetBasePropertyInfo.Value.DynamicInvoke(deg, packetBasePropertyInfo.Key.Item1.GetCustomAttributes().Any(s => s.ToString() == "System.Runtime.CompilerServices.NullableAttribute") ? null : string.Empty);
                    }
                    else if (packetBasePropertyInfo.Key.Item2.IsOptional
                             && Nullable.GetUnderlyingType(packetBasePropertyInfo.Key.Item1) != null)
                    {
                        packetBasePropertyInfo.Value.DynamicInvoke(deg, null);
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
            }

            return deg;
        }

        private static bool IsPresent(Type packetType, string propertyName, IPacket packet)
        {
            if (packetType.GetProperty(propertyName)?.GetCustomAttribute<PacketPresentWhenAttribute>() is not { } presentWhen)
            {
                return true;
            }

            var value = packetType.GetProperty(presentWhen.Field)?.GetValue(packet);
            return presentWhen.Values.Any(expected => Equals(expected, value));
        }

        private static string? JoinedSeparator(Tuple<Type, PacketIndexAttribute, string, IEnumerable<ValidationAttribute>> property) =>
            property.Item2 is not PacketListIndexAttribute
            && (IsScalar(property.Item1) || property.Item1 == typeof(string))
            && property.Item2.SpecialSeparator is { Length: > 0 } separator && !separator.Any(char.IsWhiteSpace)
                ? separator
                : null;

        private static bool IsScalar(Type type)
        {
            var underlying = Nullable.GetUnderlyingType(type) ?? type;
            return underlying.IsEnum || underlying.IsPrimitive || underlying == typeof(Guid);
        }

        private object? DeserializeValue(Tuple<Type, PacketIndexAttribute, string, IEnumerable<ValidationAttribute>> packetBasePropertyInfo, Type item1, ref string[] matches, ref int currentIndex, bool isMaxIndex, int reserved = 0)
        {
            switch (item1)
            {
                case var prop when prop == typeof(string):
                    var text = DeserializeString(matches, ref currentIndex, isMaxIndex);
                    return packetBasePropertyInfo.Item2.EscapeSpaces && text is string escaped
                        ? escaped.Replace(packetBasePropertyInfo.Item2.SpaceEscape, " ", StringComparison.Ordinal)
                        : text;
                case var prop when prop == typeof(Guid) || prop == typeof(Guid?):
                    return DeserializeGuid(matches[currentIndex++]);
                case var prop when prop == typeof(bool) || prop == typeof(bool?):
                    return DeserializeBoolean(matches[currentIndex++]);
                case var prop when (prop.BaseType?.Equals(typeof(Enum)) ?? false) ||
                    (Nullable.GetUnderlyingType(prop)?.IsEnum ?? false):
                    return DeserializeEnum(item1, matches[currentIndex++]);
                case var prop when prop == typeof(Game18NArguments):
                    // Game18NArguments is a custom non-generic IList<object>. The generic
                    // list path can't figure out its element type (GetGenericArguments() is
                    // empty) and can't assign List<object> to it, so sayi/msgi/msgi2 all
                    // crashed with IndexOutOfRange. Consume the remaining tokens directly
                    // into a fresh Game18NArguments; numeric tokens go in as long, the rest
                    // as string.
                    var argumentCount = packetBasePropertyInfo.Item2 is PacketListIndexAttribute { Length: > 0 } fixedLength
                        ? Math.Min((int)fixedLength.Length, matches.Length - currentIndex)
                        : matches.Length - currentIndex;
                    var g18n = new Game18NArguments(Math.Max(1, argumentCount));
                    var argumentEnd = currentIndex + argumentCount;
                    while (currentIndex < argumentEnd)
                    {
                        var token = matches[currentIndex++];
                        g18n.Add(long.TryParse(token, out var longValue) ? (object)longValue : token);
                    }
                    return g18n;
                case var prop when prop.IsArray:
                    var items = DeserializeList(prop.GetElementType()!, packetBasePropertyInfo.Item2, matches, ref currentIndex, isMaxIndex, reserved) as IList;
                    var array = Array.CreateInstance(prop.GetElementType()!, items?.Count ?? 0);
                    items?.CopyTo(array, 0);
                    return array;
                case var prop when typeof(ICollection).IsAssignableFrom(prop):
                    return DeserializeList(packetBasePropertyInfo.Item1.GetElementType() ?? packetBasePropertyInfo.Item1.GetGenericArguments()[0], packetBasePropertyInfo.Item2, matches, ref currentIndex, isMaxIndex, reserved);
                case var prop when prop == typeof(IPacket) && packetBasePropertyInfo.Item2.RemoveHash && isMaxIndex:
                    var inlinePacket = string.Join(' ', matches.Skip(currentIndex));
                    currentIndex = matches.Length;
                    return Deserialize(inlinePacket);
                case var prop when prop == typeof(IPacket):
                    return Deserialize(matches[currentIndex++]);
                case var prop when typeof(IPacket).IsAssignableFrom(prop):
                    // A field typed with a family of packets sharing one header (e_info) has nothing to say which
                    // one it holds, so it is skipped rather than read as the wrong one.
                    if ((_packetDeserializerDictionary.Values.FirstOrDefault(creator => creator.PacketType == prop)
                        ?? (_packetDeserializerDictionary.TryGetValue(prop.Name, out var named) ? named : null)) is not { } dic)
                    {
                        currentIndex++;
                        return null;
                    }

                    var subPacketSeparator = packetBasePropertyInfo.Item2 is PacketListIndexAttribute ind ? ind.ListSeparator : packetBasePropertyInfo.Item2.SpecialSeparator;
                    // The serializer joins a header-less sub-packet's fields with spaces unless it names a separator;
                    // a client line can still join them with dots.
                    if (subPacketSeparator == " " || (subPacketSeparator == null && prop.GetCustomAttribute<PacketHeaderAttribute>() == null
                        && !(currentIndex < matches.Length && IsJoinedSubPacket(matches[currentIndex], prop, "."))))
                    {
                        if (packetBasePropertyInfo.Item2.IsOptional && (currentIndex >= matches.Length || matches[currentIndex].Length == 0))
                        {
                            return null;
                        }

                        return DeserializeFields(dic, ref matches, ref currentIndex, hasHeader: false, inLine: true, lastInLine: isMaxIndex);
                    }
                    // An absent sub-packet is written as a lone -1 in place of its joined fields.
                    if (subPacketSeparator is { Length: > 0 } && matches[currentIndex] == "-1"
                        && prop.GetProperties().Count(p => p.GetCustomAttribute<PacketIndexAttribute>() != null) > 1)
                    {
                        currentIndex++;
                        return null;
                    }

                    var subPacketContent = matches[currentIndex].Replace(subPacketSeparator ?? (prop.GetCustomAttribute<PacketHeaderAttribute>() == null ? "." : "^"), " ");
                    // A value field with its own separator ("vnum.current/total") is split on that one too.
                    foreach (var fieldSeparator in prop.GetProperties()
                        .Where(p => !typeof(IPacket).IsAssignableFrom(p.PropertyType))
                        .Select(p => p.GetCustomAttribute<PacketIndexAttribute>()?.SpecialSeparator)
                        .OfType<string>()
                        .Where(separator => separator.Length > 0 && separator != " ")
                        .Distinct())
                    {
                        subPacketContent = subPacketContent.Replace(fieldSeparator, " ");
                    }
                    var packet = DeserializeIPacket(dic, subPacketContent, false, false);
                    currentIndex++;
                    return packet;
                // An optional field that is null is left off the line, so a -1 there is the value itself.
                case var prop when packetBasePropertyInfo.Item2.IsOptional && matches[currentIndex] == "-1"
                    && Nullable.GetUnderlyingType(prop) is { IsPrimitive: true } underlying:
                    currentIndex++;
                    return Convert.ChangeType(-1, underlying);
                default:
                    return DeserializeDefault(item1, matches[currentIndex++]);
            }
        }

        private object? DeserializeList(Type subType, PacketIndexAttribute packetIndexAttribute, string[] matches, ref int currentIndex, bool isMaxIndex, int reserved = 0)
        {
            var newIndex = currentIndex;
            var length = packetIndexAttribute is PacketListIndexAttribute listIndex ? listIndex.Length : 0;
            string[]? splited = null;

            if (length < 0)
            {
                length = sbyte.Parse(matches[currentIndex + length]);
            }
            else
            {

                var separator = packetIndexAttribute.SpecialSeparator;
                if (packetIndexAttribute is PacketListIndexAttribute ind)
                {
                    // For IPacket (sub-packet) lists, SpecialSeparator on the list names
                    // the *inner field* separator inside each sub-packet — not the list
                    // item separator. The list items are tokenised by the outer packet's
                    // whitespace. Only ListSeparator (when explicitly set) defines how
                    // items are joined. For primitive lists, SpecialSeparator remains the
                    // inter-item separator, defaulting to ".".
                    separator = ind.ListSeparator ?? (typeof(IPacket).IsAssignableFrom(subType) ? null : separator ?? ".");
                }
                if (isMaxIndex && string.IsNullOrWhiteSpace(separator))
                {
                    var lastToken = matches.Length;
                    while (lastToken > currentIndex && matches[lastToken - 1].Length == 0)
                    {
                        lastToken--;
                    }

                    // A client line can end with a space, which would otherwise read as one more empty item.
                    var remainingTokens = lastToken - currentIndex;
                    // Sub-packets whose fields are space-separated span several tokens each
                    // (exc_list's "type slot amount"), so the item count is tokens / fields.
                    var subPacketCreator = typeof(IPacket).IsAssignableFrom(subType) && remainingTokens > 0
                        && !IsJoinedSubPacket(matches[currentIndex], subType, packetIndexAttribute.SpecialSeparator ?? ".")
                        ? _packetDeserializerDictionary.Values.FirstOrDefault(s => s.PacketType == subType)
                        : null;
                    var tokensPerItem = subPacketCreator == null ? 1 : subPacketCreator.PropertyAmount + 1;
                    length = (sbyte)((remainingTokens + tokensPerItem - 1) / tokensPerItem);
                }

                if (!string.IsNullOrWhiteSpace(separator))
                {
                    splited = matches[currentIndex].Split(new[] { separator }, StringSplitOptions.RemoveEmptyEntries);
                    length = (sbyte)splited.Length;
                }
                else if (length == 0 && !isMaxIndex && separator == null && typeof(IPacket).IsAssignableFrom(subType))
                {
                    // A list followed by other fields runs while its items look like this sub-packet, or are
                    // the "-1" of an empty entry.
                    var end = currentIndex;
                    while (end < matches.Length
                        && (matches[end] == "-1" || IsJoinedSubPacket(matches[end], subType, packetIndexAttribute.SpecialSeparator ?? ".")))
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
                    if (typeof(IPacket).IsAssignableFrom(subType))
                    {
                        var subPacketCreator = _packetDeserializerDictionary.Values.FirstOrDefault(s => s.PacketType == subType);
                        length = subPacketCreator == null ? 0 : Math.Max(0, available / (subPacketCreator.PropertyAmount + 1));
                    }
                    else
                    {
                        var end = currentIndex;
                        while (end < currentIndex + available && long.TryParse(matches[end], out _))
                        {
                            end++;
                        }

                        length = end - currentIndex;
                    }
                }
            }

            if (length > 0)
            {
                var list = new List<object?>();
                for (var i = 0; i < length; i++)
                {
                    if (typeof(IPacket).IsAssignableFrom(subType))
                    {
                        var dic = _packetDeserializerDictionary.Values.FirstOrDefault(s => s.PacketType == subType);

                        if (dic == null)
                        {
                            continue;
                        }

                        var toConvert = "";
                        var joined = IsJoinedSubPacket(matches[currentIndex + i], subType, packetIndexAttribute.SpecialSeparator ?? ".");

                        if (matches[currentIndex + i] == "-1")
                        {
                            list.Add(null);
                            if (splited == null)
                            {
                                newIndex++;
                            }

                            continue;
                        }

                        if (joined)
                        {
                            toConvert = SplitJoined(matches[currentIndex + i], subType, packetIndexAttribute.SpecialSeparator ?? ".");
                        }
                        else
                        {
                            toConvert = string.Join(" ",
                                matches.Skip(currentIndex + i * (1 + dic.PropertyAmount)).Take(dic.PropertyAmount + 1));
                        }
                        list.Add(Convert.ChangeType(DeserializeIPacket(dic, toConvert, false, false), subType));

                        if (splited == null)
                        {
                            newIndex += joined ? 1 : 1 + dic.PropertyAmount;
                        }
                    }
                    else //simple list
                    {
                        var value = long.Parse(splited != null ? splited[i] : matches[currentIndex + i]);
                        list.Add(value == -1 ? null : Convert.ChangeType(value, Nullable.GetUnderlyingType(subType) ?? subType));
                        if (splited == null)
                        {
                            newIndex++;
                        }
                    }
                }

                if (splited != null)
                {
                    newIndex++;
                }

                currentIndex = newIndex;
                return _getAndFillListMethods.GetOrAdd(subType, (type) => type.GetAndFillListMethod())(list);
            }

            return null;
        }

        // Splits a sub-packet written as one token into a token per field. When the line carries fewer fields
        // than the class, the optional ones are the ones left out, latest first, and read as absent.
        private static string SplitJoined(string token, Type subType, string listSeparator)
        {
            var fields = subType.GetProperties()
                .Select(property => (Property: property, Index: property.GetCustomAttribute<PacketIndexAttribute>()))
                .Where(field => field.Index != null)
                .OrderBy(field => field.Index!.Index)
                .ToList();
            var parts = new List<string>();
            var rest = token;
            for (var index = 1; index < fields.Count; index++)
            {
                var separator = fields[index].Index!.SpecialSeparator ?? listSeparator;
                var at = separator.Length == 0 ? -1 : rest.IndexOf(separator, StringComparison.Ordinal);
                if (at < 0)
                {
                    break;
                }

                parts.Add(rest[..at]);
                rest = rest[(at + separator.Length)..];
            }

            parts.Add(rest);
            var absent = new HashSet<int>();
            for (var index = fields.Count - 1; index >= 0 && fields.Count - absent.Count > parts.Count; index--)
            {
                if (fields[index].Index!.IsOptional)
                {
                    absent.Add(index);
                }
            }

            var tokens = new List<string>();
            var next = 0;
            for (var index = 0; index < fields.Count && next < parts.Count; index++)
            {
                tokens.Add(absent.Contains(index)
                    ? fields[index].Property.PropertyType == typeof(string) ? "-" : string.Empty
                    : parts[next++]);
            }

            return string.Join(' ', tokens);
        }

        // A sub-packet written as one token joins its fields with the list's separator, or with the
        // separator a field names for itself (gexp's "id|experience").
        private static bool IsJoinedSubPacket(string token, Type subType, string listSeparator) =>
            token.Contains(listSeparator) || subType.GetProperties()
                .Select(property => property.GetCustomAttribute<PacketIndexAttribute>())
                .Where(index => index is { Index: > 0 } && !string.IsNullOrEmpty(index.SpecialSeparator) && index.SpecialSeparator != " ")
                .Any(index => token.Contains(index!.SpecialSeparator!));

        private object? DeserializeEnum(Type type, string value)
        {
            var enumType = Nullable.GetUnderlyingType(type) ?? type;
            return (value == "-1" && !(Enum.TryParse(enumType, value, out var minusOne) && Enum.IsDefined(enumType, minusOne!)))
                || IsAbsentOptional(type, value)
                ? type.GetDefaultValue()
                : Enum.Parse(enumType, value);
        }

        // The client ends some packets with a separator, which leaves an empty last field.
        private static bool IsAbsentOptional(Type type, string value) =>
            value.Length == 0 && Nullable.GetUnderlyingType(type) != null;

        private object? DeserializeBoolean(string value)
        {
            return value == "-1" ? (bool?)null : value == "1";
        }

        private object? DeserializeGuid(string value)
        {
            return value == "NONE" ? (Guid?)null : Guid.Parse(value);
        }

        private object? DeserializeDefault(Type type, string value)
        {
            return (value == "-1" && !type.IsPrimitive) || IsAbsentOptional(type, value)
                ? type.GetDefaultValue()
                : Convert.ChangeType(value, Nullable.GetUnderlyingType(type) ?? type);
        }

        private object? DeserializeString(string[] matches, ref int currentIndex, bool isMaxIndex)
        {
            if (isMaxIndex)
            {
                var packet = new StringBuilder();
                for (var i = currentIndex; i < matches.Length; i++)
                {
                    if (i != currentIndex)
                    {
                        packet.Append(" ");
                    }

                    packet.Append(matches[i]);
                }

                currentIndex = matches.Length - 1;
                return packet.ToString();
            }
            else if (matches[currentIndex] == "-")
            {
                currentIndex++;
                return null;
            }
            else
            {
                return matches[currentIndex++];
            }
        }
    }
}