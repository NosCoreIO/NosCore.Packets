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
            var header = typeof(T).GetCustomAttribute<PacketHeaderAttribute>()?.Identification;
            if (_packetDeserializerDictionary.ContainsKey(header ?? typeof(T).Name))
            {
                if (typeof(T).Namespace!.Contains("ServerPackets"))
                {
                    return;
                }

                _packetDeserializerDictionary.Remove(header ?? typeof(T).Name);
            }

            var types = typeof(T).GetProperties()
                    .Where(x => x.GetCustomAttributes(true).OfType<PacketIndexAttribute>().Any()).ToList();
            var propertyAmount = types.Any() ? types.Max(x => x.GetCustomAttributes(true).OfType<PacketIndexAttribute>().First().Index) : 0;

            var ctor = typeof(T).GetConstructors(BindingFlags.Instance | BindingFlags.Public)
                .OrderBy(x => x.GetParameters().Length).First();

            var parameters = ctor.GetParameters();
            var parameterExpression = parameters.Select(p => Expression.Default(p.ParameterType)).ToArray();


            var creator = new TypeCreator
            {
                PacketType = typeof(T),
                PropertyAmount = propertyAmount,
                Constructor = Expression.Lambda(Expression.New(ctor, parameterExpression)).Compile(),
                PacketDeserializerDictionary = GeneratePacketDeserializerDictionary(typeof(T))
            };

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
                    var dic = _packetDeserializerDictionary[packetsplit[header]];
                    var packet = DeserializeIPacket(dic, isSpecial ? packetstring : packetContent, includesKeepAliveIdentity, true);
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

        private IPacket? DeserializeIPacket(TypeCreator dic, string packetContent, bool includesKeepAliveIdentity, bool hasHeader)
        {
            var deg = (IPacket)dic.Constructor!.DynamicInvoke()!;

            var matches = Regex.Matches(packetContent, @"([^\s\v]+)|(?<=\s)(?=\s|$)")
                .Select(s => s.Value).ToArray();

            if (matches.Length > 0 && dic.PacketDeserializerDictionary.Count > 0)
            {
                var maxindex = dic.PacketDeserializerDictionary.Max(s => s.Key.Item2.Index);
                var trueIndex = -1;
                foreach (var packetBasePropertyInfo in dic.PacketDeserializerDictionary)
                {
                    var isMaxIndex = packetBasePropertyInfo.Key.Item2.Index == maxindex;
                    var keepaliveIndex = includesKeepAliveIdentity ? 1 : 0;
                    var currentIndex = packetBasePropertyInfo.Key.Item2.Index + (hasHeader ? 1 : 0) + keepaliveIndex;
                    trueIndex = trueIndex == -1 ? currentIndex : trueIndex;
                    if (currentIndex < matches.Length)
                    {
                        var value = DeserializeValue(packetBasePropertyInfo.Key, packetBasePropertyInfo.Key.Item1,
                            matches, ref trueIndex, isMaxIndex);
                        
                        packetBasePropertyInfo.Value.DynamicInvoke(deg, value);
                    }
                    else if (isMaxIndex && packetBasePropertyInfo.Key.Item1 == typeof(string))
                    {
                        packetBasePropertyInfo.Value.DynamicInvoke(deg, packetBasePropertyInfo.Key.Item1.GetCustomAttributes().Any(s => s.ToString() == "System.Runtime.CompilerServices.NullableAttribute") ? null : string.Empty);
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return deg;
        }

        private object? DeserializeValue(Tuple<Type, PacketIndexAttribute, string, IEnumerable<ValidationAttribute>> packetBasePropertyInfo, Type item1, string[] matches, ref int currentIndex, bool isMaxIndex)
        {
            switch (item1)
            {
                case var prop when prop == typeof(string):
                    return DeserializeString(matches, ref currentIndex, isMaxIndex);
                case var prop when prop == typeof(Guid) || prop == typeof(Guid?):
                    return DeserializeGuid(matches[currentIndex++]);
                case var prop when prop == typeof(bool) || prop == typeof(bool?):
                    return DeserializeBoolean(matches[currentIndex++]);
                case var prop when (prop.BaseType?.Equals(typeof(Enum)) ?? false) ||
                    (Nullable.GetUnderlyingType(prop)?.IsEnum ?? false):
                    return DeserializeEnum(item1, matches[currentIndex++]);
                case var prop when typeof(ICollection).IsAssignableFrom(prop):
                    return DeserializeList(packetBasePropertyInfo.Item1.GetElementType() ?? packetBasePropertyInfo.Item1.GetGenericArguments()[0], packetBasePropertyInfo.Item2, matches, ref currentIndex, isMaxIndex);
                case var prop when prop == typeof(IPacket):
                    return Deserialize(matches[currentIndex++]);
                case var prop when typeof(IPacket).IsAssignableFrom(prop):
                    var dic = _packetDeserializerDictionary[prop.Name];
                    var packet = DeserializeIPacket(dic, matches[currentIndex].Replace((packetBasePropertyInfo.Item2 is PacketListIndexAttribute ind ? ind.ListSeparator : packetBasePropertyInfo.Item2.SpecialSeparator) ?? ".", " "), false, false);
                    currentIndex++;
                    return packet;
                default:
                    return DeserializeDefault(item1, matches[currentIndex++]);
            }
        }

        private object? DeserializeList(Type subType, PacketIndexAttribute packetIndexAttribute, string[] matches, ref int currentIndex, bool isMaxIndex)
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
                    separator = ind.ListSeparator ?? (typeof(IPacket).IsAssignableFrom(subType) ? separator : ".");
                }
                if (isMaxIndex && string.IsNullOrWhiteSpace(separator))
                {
                    length = (sbyte)(matches.Length - currentIndex);
                }

                if (!string.IsNullOrWhiteSpace(separator))
                {
                    splited = matches[currentIndex].Split(new[] { separator }, StringSplitOptions.RemoveEmptyEntries);
                    length = (sbyte)splited.Length;
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

                        if (matches[currentIndex + i].Contains(packetIndexAttribute.SpecialSeparator ?? "."))
                        {
                            var subpacket = matches[currentIndex + i];

                            var packSeperators = subType.GetProperties()
                                .Select(prop => prop.GetCustomAttribute<PacketIndexAttribute>()).Where(s => s != null).ToList();

                            for (var index = 0; index < packSeperators.Count; index++)
                            {
                                var c = index == packSeperators.Count - 1 ? -1 : subpacket.IndexOf(packSeperators[index + 1]!.SpecialSeparator ?? ".", StringComparison.Ordinal);
                                if (c == -1)
                                {
                                    toConvert += subpacket;
                                }
                                else
                                {
                                    toConvert += subpacket.Substring(0, c) + " ";
                                    subpacket = subpacket.Substring(c + 1);
                                }
                            }
                        }
                        else
                        {
                            toConvert = string.Join(" ",
                                matches.Skip(currentIndex + i * (1 + dic.PropertyAmount)).Take(dic.PropertyAmount + 1));
                        }
                        list.Add(Convert.ChangeType(DeserializeIPacket(dic, toConvert, false, false), subType));

                        if (splited == null)
                        {
                            newIndex += 1 + dic.PropertyAmount;
                        }
                    }
                    else //simple list
                    {
                        var value = long.Parse(splited != null ? splited[i] : matches[currentIndex + i]);
                        list.Add(value == -1 ? null : Convert.ChangeType(value, Nullable.GetUnderlyingType(subType) ?? subType));
                        if (splited == null)
                        {
                            newIndex += i + 1;
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

        private object DeserializeEnum(Type type, string value)
        {
            return value == "-1" ? type.GetDefaultValue() : Enum.Parse(Nullable.GetUnderlyingType(type) ?? type, value);
        }

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
            return value == "-1" && !type.IsPrimitive ? type.GetDefaultValue() : Convert.ChangeType(value, Nullable.GetUnderlyingType(type) ?? type);
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