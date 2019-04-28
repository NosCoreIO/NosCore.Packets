using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets
{
    public class TypeCreator
    {
        public int PropertyAmount { get; set; }
        public Type PacketType { get; set; }
        public Delegate Constructor { get; set; }

        public Dictionary<Tuple<Type, PacketIndexAttribute>, Delegate> packetDeserializerDictionary = new Dictionary<Tuple<Type, PacketIndexAttribute>, Delegate>();
    }

    //TODO make those expression tree cached
    public static class TypeExtension
    {
        public static object GetDefaultValue(this Type type)
        {
            if (type == null) throw new ArgumentNullException("type");
            Expression<Func<object>> e = Expression.Lambda<Func<object>>(
                Expression.Convert(
                    Expression.Default(type), typeof(object)
                )
            );

            return e.Compile()();
        }

        //https://stackoverflow.com/questions/35913495/moving-from-reflection-to-expression-tree
        public static Func<IEnumerable<object>, object> GetAndFillListMethod(this Type genericType)
        {
            var listType = typeof(List<>);
            var listGenericType = listType.MakeGenericType(genericType);

            var values = Expression.Parameter(typeof(IEnumerable<object>), "values");

            var ctor = listGenericType.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, new Type[0], null);

            // I prefer using Expression.Variable to Expression.Parameter
            // for internal variables
            var instance = Expression.Variable(listGenericType, "list");

            var assign = Expression.Assign(instance, Expression.New(ctor));

            var addMethod = listGenericType.GetMethod("AddRange", new[] { typeof(IEnumerable<>).MakeGenericType(genericType) });

            // Enumerable.Cast<T>
            var castMethod = typeof(Enumerable).GetMethod("Cast", new[] { typeof(IEnumerable) }).MakeGenericMethod(genericType);

            // For the parameters there is a params Expression[], so no explicit array necessary
            var castCall = Expression.Call(castMethod, values);
            var addCall = Expression.Call(instance, addMethod, castCall);

            var block = Expression.Block(
                new[] { instance },
                assign,
                addCall,
                Expression.Convert(instance, typeof(object))
            );

            return (Func<IEnumerable<object>, object>)Expression.Lambda(block, values).Compile();
        }
    }

    public class Deserializer : IDeserializer
    {
        private readonly Dictionary<string, TypeCreator> packetDeserializerDictionary = new Dictionary<string, TypeCreator>();

        public Deserializer(IEnumerable<Type> types)
        {
            var deserializerMethod = typeof(Deserializer).GetMethod(nameof(Initialize));
            foreach (var type in types)
            {
                deserializerMethod.MakeGenericMethod(type).Invoke(this, null);
            }
        }

        public void Initialize<T>() where T : PacketBase
        {
            var header = typeof(T).GetCustomAttribute<PacketHeaderAttribute>()?.Identification;
            if (!packetDeserializerDictionary.ContainsKey(header ?? typeof(T).Name))
            {
                var types = typeof(T).GetProperties()
                    .Where(x => x.GetCustomAttributes(true).OfType<PacketIndexAttribute>().Any());
                var propertyAmount = types.Any() ? types.Max(x => x.GetCustomAttributes(true).OfType<PacketIndexAttribute>().First().Index) : 0;

                var creator = new TypeCreator
                {
                    PacketType = typeof(T),
                    PropertyAmount = propertyAmount,
                    Constructor = Expression.Lambda(Expression.New(typeof(T))).Compile(),
                    packetDeserializerDictionary = GeneratePacketDeserializerDictionary(typeof(T))
                };

                packetDeserializerDictionary.Add(header ?? typeof(T).Name, creator);
            }
        }

        private Delegate GetPropSetter(Type typeObj, Type typeProperty, string propertyName)
        {
            ParameterExpression paramExpression = Expression.Parameter(typeObj);

            ParameterExpression paramExpression2 = Expression.Parameter(typeProperty, propertyName);

            MemberExpression propertyGetterExpression = Expression.Property(paramExpression, propertyName);

            return Expression.Lambda
            (
                Expression.Assign(propertyGetterExpression, paramExpression2), paramExpression, paramExpression2
            ).Compile();
        }

        private Dictionary<Tuple<Type, PacketIndexAttribute>, Delegate> GeneratePacketDeserializerDictionary(Type type)
        {
            var dic = new Dictionary<Tuple<Type, PacketIndexAttribute>, Delegate>();
            var properties = type.GetProperties()
                .Where(x => x.GetCustomAttributes(true).OfType<PacketIndexAttribute>().Any())
                .OrderBy(x => x.GetCustomAttributes(true).OfType<PacketIndexAttribute>().First().Index).ToList();
            foreach (var packetBasePropertyInfo in properties)
            {
                var packetIndex = packetBasePropertyInfo.GetCustomAttributes(true).OfType<PacketIndexAttribute>()
                    .First();

                dic.Add(new Tuple<Type, PacketIndexAttribute>(packetBasePropertyInfo.PropertyType, packetIndex), GetPropSetter(type, packetBasePropertyInfo.PropertyType, packetBasePropertyInfo.Name));
            }

            return dic;
        }

        public IPacket Deserialize(string packetContent)
        {
            try
            {
                var packetstring = packetContent.Replace('^', ' ').Replace("#", "").TrimEnd();
                var packetsplit = packetstring.Split(' ');
                if (packetsplit.Length < 1)
                {
                    throw new InvalidOperationException();
                }
                bool includesKeepAliveIdentity = ushort.TryParse(packetsplit[0], out var keepalive);
                var header = includesKeepAliveIdentity ? 1 : 0;
                if (packetsplit[header].Length >= 1
                    && (packetsplit[header][0] == '/' || packetsplit[header][0] == ':' || packetsplit[header][0] == ';'))
                {
                    packetsplit[header] = packetsplit[header][0].ToString();
                    packetContent = packetContent.Insert(packetContent.IndexOf(packetsplit[header][0]) + 1, " ");
                }

                if (packetDeserializerDictionary.ContainsKey(packetsplit[header]))
                {
                    var dic = packetDeserializerDictionary[packetsplit[header]];
                    var packet = DeserializeIPacket(dic, packetContent, includesKeepAliveIdentity, true);
                    packet.Header = packetsplit[header];
                    packet.KeepAliveId = includesKeepAliveIdentity ? (ushort?)keepalive : null;
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
            catch
            {
                var exc = new ArgumentException();
                exc.Data["Packet"] = packetContent;
                throw exc;
            }
        }

        private IPacket DeserializeIPacket(TypeCreator dic, string packetContent, bool includesKeepAliveIdentity, bool hasHeader)
        {
            var deg = (IPacket)dic.Constructor.DynamicInvoke();
            var matches = Regex.Matches(packetContent, @"([^\040]+[\.][^\040]+[\040]?)+((?=\040)|$)|([^\040]+)((?=\040)|$)").OfType<Match>()
                .ToArray();

            if (matches.Length > 0 && dic.packetDeserializerDictionary.Count > 0)
            {
                var maxindex = dic.packetDeserializerDictionary.Max(s => s.Key.Item2.Index);
                var trueIndex = -1;
                foreach (var packetBasePropertyInfo in dic.packetDeserializerDictionary)
                {
                    var isMaxIndex = packetBasePropertyInfo.Key.Item2.Index == maxindex;
                    var keepaliveIndex = includesKeepAliveIdentity ? 1 : 0;
                    var currentIndex = packetBasePropertyInfo.Key.Item2.Index + (hasHeader ? 1 : 0) + keepaliveIndex;
                    trueIndex = trueIndex == -1 ? currentIndex : trueIndex ;
                    if (currentIndex < matches.Length)
                    {
                        packetBasePropertyInfo.Value.DynamicInvoke(deg,
                            DeserializeValue(packetBasePropertyInfo.Key, packetBasePropertyInfo.Key.Item1, matches, ref trueIndex, isMaxIndex));
                    }
                    else if (isMaxIndex && packetBasePropertyInfo.Key.Item1 == typeof(string))
                    {
                        packetBasePropertyInfo.Value.DynamicInvoke(deg, string.Empty);
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return deg;
        }

        private object DeserializeValue(Tuple<Type, PacketIndexAttribute> packetBasePropertyInfo, Type item1, Match[] matches, ref int currentIndex, bool isMaxIndex)
        {
            switch (item1)
            {
                case var prop when prop == typeof(string):
                    return DeserializeString(matches, ref currentIndex, isMaxIndex);
                case var prop when prop == typeof(Guid) || prop == typeof(Guid?):
                    return DeserializeGuid(matches[currentIndex++].ToString());
                case var prop when prop == typeof(bool) || prop == typeof(bool?):
                    return DeserializeBoolean(matches[currentIndex++].ToString());
                case var prop when (prop.BaseType?.Equals(typeof(Enum)) ?? false) ||
                    (Nullable.GetUnderlyingType(prop)?.IsEnum ?? false):
                    return DeserializeEnum(item1, matches[currentIndex++].ToString());
                case var prop when typeof(ICollection).IsAssignableFrom(prop):
                    return DeserializeList(packetBasePropertyInfo.Item1.GetGenericArguments()[0], packetBasePropertyInfo.Item2.Length, matches, ref currentIndex, isMaxIndex);
                default:
                    return DeserializeDefault(item1, matches[currentIndex++].ToString());
            }
        }

        private object DeserializeList(Type subType, sbyte length, Match[] matches, ref int currentIndex, bool isMaxIndex)
        {
            int newIndex = currentIndex;
            if (isMaxIndex)
            {
                length = (sbyte)(matches.Length - currentIndex);
            }

            if (length == -1)
            {
                length = sbyte.Parse(matches[currentIndex].Value);
            }

            if (length > 0)
            {
                var list = new List<object>();
                for (var i = 0; i < length; i++)
                {
                    if (typeof(IPacket).IsAssignableFrom(subType))
                    {
                        var dic = packetDeserializerDictionary.Values.FirstOrDefault(s => s.PacketType == subType);

                        if (dic == null)
                        {
                            continue;
                        }

                        list.Add(Convert.ChangeType(DeserializeIPacket(dic, string.Join(" ", matches.Skip(currentIndex + i * (1 + dic.PropertyAmount)).Take(dic.PropertyAmount + 1)), false, false), subType));
                        newIndex += 1 + dic.PropertyAmount;
                    }
                    else //simple list
                    {
                        list.Add(Convert.ChangeType(matches[currentIndex + i].Value, subType));
                        newIndex += i + 1;
                    }
                }

                currentIndex = newIndex;
                return subType.GetAndFillListMethod()(list);
            }

            return null;
        }

        private object DeserializeEnum(Type type, string value)
        {
            return value == "-1" ? type.GetDefaultValue() : Enum.Parse(type, value);
        }

        private object DeserializeBoolean(string value)
        {
            return value == "-1" ? (bool?)null : value == "1";
        }

        private object DeserializeGuid(string value)
        {
            return value == "NONE" ? (Guid?)null : Guid.Parse(value);
        }

        private object DeserializeDefault(Type type, string value)
        {
            return value == "-1" ? type.GetDefaultValue() : Convert.ChangeType(value, Nullable.GetUnderlyingType(type) ?? type);
        }

        private object DeserializeString(Match[] matches, ref int currentIndex, bool isMaxIndex)
        {
            if (isMaxIndex)
            {
                StringBuilder packet = new StringBuilder();
                for (int i = currentIndex; i < matches.Length; i++)
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
            else if (matches[currentIndex].ToString() == "-")
            {
                currentIndex++;
                return null;
            }
            else
            {
                return matches[currentIndex++].ToString();
            }
        }
    }
}