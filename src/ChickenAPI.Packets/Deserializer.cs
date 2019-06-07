using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public Dictionary<Tuple<Type, PacketIndexAttribute, string, IEnumerable<ValidationAttribute>>, Delegate> packetDeserializerDictionary = new Dictionary<Tuple<Type, PacketIndexAttribute, string, IEnumerable<ValidationAttribute>>, Delegate>();
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
            if (packetDeserializerDictionary.ContainsKey(header ?? typeof(T).Name))
            {
                if (typeof(T).Namespace.Contains("ServerPackets"))
                {
                    return;
                }

                packetDeserializerDictionary.Remove(header ?? typeof(T).Name);
            }

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
                bool isSpecial = false;
                var packetstring = packetContent.Replace('^', ' ').TrimEnd();
                var packetsplit = packetstring.Split(' ');
                if (packetsplit.Length < 1)
                {
                    throw new InvalidOperationException();
                }

                bool includesKeepAliveIdentity = ushort.TryParse(packetsplit[0], out var keepalive);
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

                if (packetDeserializerDictionary.ContainsKey(packetsplit[header]))
                {
                    var dic = packetDeserializerDictionary[packetsplit[header]];
                    var packet = DeserializeIPacket(dic, isSpecial ? packetstring : packetContent, includesKeepAliveIdentity, true);
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
            var matches = Regex.Matches(packetContent, @"([^\040]+[\.]+[\040]?)+((?=\040)|$)|([^\040]+)((?=\040)|$)").OfType<Match>()
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
                    trueIndex = trueIndex == -1 ? currentIndex : trueIndex;
                    if (currentIndex < matches.Length)
                    {
                        var value = DeserializeValue(packetBasePropertyInfo.Key, packetBasePropertyInfo.Key.Item1,
                            matches, ref trueIndex, isMaxIndex);
                        foreach (var validation in packetBasePropertyInfo.Key.Item4)
                        {
                            var validate = validation.GetValidationResult(value, new ValidationContext(deg)
                            {
                                MemberName = packetBasePropertyInfo.Key.Item3,
                            });

                            deg.ValidationResult = validate;
                        }

                        if (packetBasePropertyInfo.Key.Item1.IsEnum && !Enum.IsDefined(packetBasePropertyInfo.Key.Item1, value))
                        {
                            deg.ValidationResult = new ValidationResult("Invalid Enum value",
                                new[] {packetBasePropertyInfo.Key.Item3});
                        }

                        if (deg.ValidationResult?.ErrorMessage.Length > 0)
                        {
                            deg.IsValid = false;
                        }

                        packetBasePropertyInfo.Value.DynamicInvoke(deg, value);
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

        private object DeserializeValue(Tuple<Type, PacketIndexAttribute, string, IEnumerable<ValidationAttribute>> packetBasePropertyInfo, Type item1, Match[] matches, ref int currentIndex, bool isMaxIndex)
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
                    return DeserializeList(packetBasePropertyInfo.Item1.GetGenericArguments()[0], packetBasePropertyInfo.Item2, matches, ref currentIndex, isMaxIndex);
                case var prop when prop == typeof(IPacket):
                    return Deserialize(matches[currentIndex++].ToString());
                default:
                    return DeserializeDefault(item1, matches[currentIndex++].ToString());
            }
        }

        private object DeserializeList(Type subType, PacketIndexAttribute packetIndexAttribute, Match[] matches, ref int currentIndex, bool isMaxIndex)
        {
            int newIndex = currentIndex;
            var length = packetIndexAttribute.Length;
            string[] splited = null;

            if (length == -1)
            {
                length = sbyte.Parse(matches[currentIndex - 1].Value);
            }
            else
            {
                if (isMaxIndex && string.IsNullOrEmpty(packetIndexAttribute.SpecialSeparator))
                {
                    length = (sbyte)(matches.Length - currentIndex);
                }
              
                if (!string.IsNullOrEmpty(packetIndexAttribute.SpecialSeparator))
                {
                    splited = matches[currentIndex].Value.Split(new string[] { packetIndexAttribute.SpecialSeparator }, StringSplitOptions.None);
                    length = (sbyte)splited.Length;
                }
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

                        string toConvert;

                        if (matches[currentIndex + i].ToString().Contains(packetIndexAttribute.SpecialSeparator ?? "."))
                        {
                            toConvert = matches[currentIndex + i].ToString().Replace(packetIndexAttribute.SpecialSeparator ?? ".", " ");
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
                        var value = long.Parse(splited != null ? splited[i] : matches[currentIndex + i].Value);
                        list.Add(Convert.ChangeType(value, subType));
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
                return subType.GetAndFillListMethod()(list);
            }

            return null;
        }

        private object DeserializeEnum(Type type, string value)
        {
            return value == "-1" ? type.GetDefaultValue() : Enum.Parse(Nullable.GetUnderlyingType(type) ?? type, value);
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