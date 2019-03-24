using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets
{
    public class Serializer : ISerializer
    {
        private const string INJECTION_KEY = "IPacketToInject";
        private Expression DefaultSerializer(Expression specificTypeExpression, string splitter)
        {
            return Expression.Call(
                typeof(string).GetMethod("Concat", new[] { typeof(object), typeof(object) }),
                Expression.Constant(splitter, typeof(object)),
                Expression.Convert(specificTypeExpression, typeof(object))
            );
        }

        private Expression StringSerializer(Expression exp, bool isLastIndex, bool isOptional, string splitter)
        {
            return Expression.Condition(
                Expression.Equal(exp, Expression.Constant(null, typeof(object))),
                Expression.Constant(isOptional ? null : $"{splitter}-", typeof(object)),
                Expression.Convert(Expression.Call(
                    typeof(string).GetMethod("Concat", new[] { typeof(object), typeof(object) }),
                    Expression.Constant(splitter, typeof(object)),
                    Expression.Convert(isLastIndex || string.IsNullOrEmpty(splitter) ? exp : Expression.Call(exp,
                        typeof(string).GetMethod("Replace", new[] { typeof(string), typeof(string) }),
                        Expression.Constant(splitter, typeof(string)),
                        Expression.Constant("^", typeof(string))
                    ), typeof(object))
                ), typeof(object))
            );
        }

        private Expression NullableSerializer(Expression exp, bool isOptional, string splitter)
        {
            return Expression.Condition(
                Expression.Equal(exp, Expression.Constant(null, typeof(object))),
                Expression.Constant(isOptional ? null : $"{splitter}-1", typeof(object)),
                Expression.Convert(Expression.Call(
                    typeof(string).GetMethod("Concat", new[] { typeof(object), typeof(object) }),
                    Expression.Constant(splitter, typeof(object)),
                    Expression.Convert(exp, typeof(object))
                ), typeof(object))
            );
        }

        private Expression EnumSerializer(Expression exp, string splitter)
        {
            var expObject = Expression.Convert(Expression.Convert(exp, typeof(long?)), typeof(object));
            return Expression.Condition(
                Expression.Equal(expObject, Expression.Default(typeof(object))),
                expObject,
                Expression.Convert(Expression.Call(
                    typeof(string).GetMethod("Concat", new[] { typeof(object), typeof(object) }),
                    Expression.Constant(splitter, typeof(object)),
                    expObject
                ), typeof(object)));
        }

        private Expression BooleanSerializer(Expression exp, string splitter)
        {
            var expbool = Expression.Convert(exp, typeof(bool?));
            return Expression.Condition(
                Expression.Equal(expbool, Expression.Constant(null, typeof(object))),
                Expression.Convert(exp, typeof(object)),
                Expression.Condition(
                    Expression.Equal(expbool, Expression.Constant(false, typeof(bool?))),
                    Expression.Constant($"{splitter}0", typeof(object)),
                    Expression.Constant($"{splitter}1", typeof(object))
                ));
        }

        private Expression ListSerializer(bool injectedPacket, Expression specificTypeExpression, PacketIndexAttribute indexAttr, Type type, string packetSplitter, string propertySplitter)
        {
            var param = Expression.Parameter(type.GenericTypeArguments[0]);
            var listJoin = Expression.Convert(Expression.Call(
                typeof(string).GetMethod("Join", new[] { typeof(string), typeof(IEnumerable<string>) }),
                Expression.Constant(packetSplitter, typeof(string)),
                Expression.Call(
                    typeof(Enumerable),
                    "Select",
                    new[] { type.GenericTypeArguments[0], typeof(string) },
                    specificTypeExpression,
                    Expression.Lambda(
                        Expression.Convert(typeof(IPacket).IsAssignableFrom(type.GenericTypeArguments[0]) ?
                            IPacketSerializer(injectedPacket, param, type.GenericTypeArguments[0], 0, propertySplitter, "") :
                            PropertySerializer(injectedPacket, indexAttr, type.GenericTypeArguments[0], param, 0, ""), typeof(string)), param)
                )), typeof(object));
            return Expression.Condition(
                Expression.Equal(specificTypeExpression, Expression.Constant(null, typeof(object))),
                Expression.Constant(null, typeof(object)),
                Expression.Convert(listJoin, typeof(object))
            );
        }

        private Expression IPacketSerializer(bool injectedPacket, Expression specificTypeExpression, Type prop, int maxIndex, string propertySplitter, string discriminator)
        {
            var properties = prop.GetProperties()
                .Where(x => x.GetCustomAttributes(true).OfType<PacketIndexAttribute>().Any())
                .OrderBy(x => x.GetCustomAttributes(true).OfType<PacketIndexAttribute>().First().Index).ToList();
            Expression propExp = Expression.Constant(injectedPacket ? $"#{discriminator}" : discriminator);

            int i = 0;
            foreach (var property in properties)
            {
                var index = property.GetCustomAttributes(true).OfType<PacketIndexAttribute>().First();
                var exp = Expression.Convert(
                    PropertySerializer(injectedPacket, index, property.PropertyType, Expression.Property(specificTypeExpression, property.Name), maxIndex,
                        injectedPacket ? "^" : index.SpecialSeparator), typeof(object));

                var removesplitter = i == 0 && string.IsNullOrEmpty(discriminator) && index.SpecialSeparator == null;
                var trimnull = Expression.Condition(
                    Expression.Equal(exp, Expression.Constant(null, typeof(object))),
                    Expression.Constant(string.Empty),
                    Expression.Call(
                        typeof(string).GetMethod("Concat", new[] { typeof(object), typeof(object) }),
                        Expression.Constant(removesplitter || injectedPacket || index.SpecialSeparator != null && i != 0 ? string.Empty : propertySplitter, typeof(object)),
                        exp
                ));

                propExp = Expression.Call(
                    typeof(string).GetMethod("Concat", new[] { typeof(object), typeof(object) }),
                    Expression.Convert(propExp, typeof(object)),
                    trimnull
                );
                i++;
            }
            return Expression.Call(
                typeof(string).GetMethod("Concat", new[] { typeof(object), typeof(object) }),
                Expression.Convert(Expression.Constant(null), typeof(object)),
                Expression.Convert(propExp, typeof(object))
            );
        }

        private Dictionary<string, Delegate> packetSerializerDictionary = new Dictionary<string, Delegate>();

        private LambdaExpression PacketSerializerExpression<T>(bool injectedPacket) where T : IPacket
        {
            var header = typeof(T).GetCustomAttribute<PacketHeaderAttribute>()?.Identification;

            if (string.IsNullOrEmpty(header))
            {
                throw new ArgumentNullException();//TODO add some error info
            }

            var properties = typeof(T).GetProperties()
                .Where(x => x.GetCustomAttributes(true).OfType<PacketIndexAttribute>().Any())
                .OrderBy(x => x.GetCustomAttributes(true).OfType<PacketIndexAttribute>().First().Index).ToList();
            var maxIndex = properties.LastOrDefault()?.GetCustomAttributes(true).OfType<PacketIndexAttribute>().First()
                .Index ?? 0;
            ParameterExpression param = Expression.Parameter(typeof(T));
            return Expression.Lambda(Expression.Convert(IPacketSerializer(injectedPacket, param, typeof(T), maxIndex, " ", header), typeof(object)), param);
        }

        private Expression PropertySerializer(bool injectedPacket, PacketIndexAttribute indexAttr, Type type, Expression specificTypeExpression, int maxIndex, string propertySplitter)
        {
            var useCustomSerializer = false;
            switch (type)
            {
                //handle boolean
                case var t when t == typeof(bool) || t == typeof(bool?):
                    specificTypeExpression = BooleanSerializer(specificTypeExpression, propertySplitter);
                    useCustomSerializer = true;
                    break;
                //handle enum
                case var t when (t.BaseType?.Equals(typeof(Enum)) ?? false) || (Nullable.GetUnderlyingType(t)?.IsEnum ?? false):
                    specificTypeExpression = EnumSerializer(specificTypeExpression, propertySplitter);
                    useCustomSerializer = true;
                    break;
                //handle list
                case var t when (t.IsGenericType && t.GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>))):
                    specificTypeExpression = ListSerializer(injectedPacket, specificTypeExpression, indexAttr, t, " ", typeof(IPacket).IsAssignableFrom(t.GenericTypeArguments[0]) ? indexAttr.SpecialSeparator ?? "." : " ");
                    useCustomSerializer = true;
                    break;
                //handle string
                case var t when t == typeof(string):
                    specificTypeExpression = StringSerializer(specificTypeExpression, indexAttr.Index == maxIndex, indexAttr.IsOptional, propertySplitter);
                    useCustomSerializer = true;
                    break;
                //IPacket declared type
                case var t when typeof(IPacket).IsAssignableFrom(t) && t != typeof(IPacket):
                    var header = specificTypeExpression.Type.GetCustomAttribute<PacketHeaderAttribute>()?.Identification;
                    propertySplitter = indexAttr.SpecialSeparator ?? ".";
                    if (!string.IsNullOrEmpty(header))
                    {
                        header = $"#{header}";
                        propertySplitter = "^";
                    }
                    specificTypeExpression = IPacketSerializer(injectedPacket, specificTypeExpression, t, maxIndex, propertySplitter, header);
                    useCustomSerializer = true;
                    break;
                case var t when t == typeof(IPacket):
                    specificTypeExpression = Expression.Constant(INJECTION_KEY, typeof(string));
                    useCustomSerializer = true;
                    break;
            }

            if (type != typeof(string) && Nullable.GetUnderlyingType(type) != null)
            {
                specificTypeExpression = NullableSerializer(specificTypeExpression, indexAttr.IsOptional, propertySplitter);
                useCustomSerializer = true;
            }

            if (!useCustomSerializer)
            {
                specificTypeExpression = DefaultSerializer(specificTypeExpression, propertySplitter);
            }

            return specificTypeExpression;
        }


        public Serializer(IEnumerable<Type> types)
        {
            var serializerMethod = typeof(Serializer).GetMethod(nameof(Initialize));
            foreach (var type in types)
            {
                serializerMethod.MakeGenericMethod(type).Invoke(this, null);
            }
        }

        public void Initialize<T>() where T : IPacket
        {
            var packetSerializerExpressionFalse = PacketSerializerExpression<T>(false);
            var packetSerializerExpressionTrue = PacketSerializerExpression<T>(true);
            packetSerializerDictionary.Add($"{typeof(T).Name}False", packetSerializerExpressionFalse.Compile());
            packetSerializerDictionary.Add($"{typeof(T).Name}True", packetSerializerExpressionTrue.Compile());
        }

        public string Serialize(IPacket packet)
        {
            var realType = packet.GetType();
            var deg = packetSerializerDictionary[$"{packet.GetType().Name}False"];
            var fullString = (string)deg.DynamicInvoke(new[] { packet });
            if (fullString.Contains(INJECTION_KEY))
            {
                //unfortunately some packets like DLG, DELAY can handle multiple type packet we can't build the full serializer at init, instead we inject serializer with reflection
                foreach (var prop in realType.GetProperties().Where(p => p.PropertyType == typeof(IPacket)))
                {
                    int Place = fullString.IndexOf(INJECTION_KEY);
                    var value = realType.GetProperty(prop.Name).GetValue(packet, null);
                    fullString = fullString
                                .Remove(Place, INJECTION_KEY.Length)
                                .Insert(Place, (string)packetSerializerDictionary[$"{value.GetType().Name}True"].DynamicInvoke(new[]
                                {
                                    value
                                }));
                }
            }
            return fullString;
        }

        public string Serialize(IEnumerable<IPacket> packets)
        {
            throw new NotImplementedException();
        }
    }
}
