using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet
{
    public class Serializer : ISerializer
    {
        private Expression StringSerializer(Expression exp, bool isLastIndex, bool isOptional)
        {
            return Expression.Condition(
                Expression.Equal(exp, Expression.Constant(null, typeof(object))),
                Expression.Constant(isOptional ? string.Empty : " -", typeof(object)),
                Expression.Convert(Expression.Call(
                    typeof(string).GetMethod("Concat", new[] { typeof(object), typeof(object) }),
                    Expression.Convert(isLastIndex ? exp : Expression.Call(exp,
                        typeof(string).GetMethod("Replace", new[] { typeof(char), typeof(char) }),
                        Expression.Constant(' '),
                        Expression.Constant('^')
                    ), typeof(object)),
                    Expression.Constant(' ', typeof(object))
                ), typeof(object))
            );
        }

        private Expression NullableSerializer(Expression exp, bool isOptional)
        {
            return Expression.Condition(
                Expression.Equal(exp, Expression.Constant(null, typeof(object))),
                Expression.Constant(isOptional ? string.Empty : " -1", typeof(object)),
                Expression.Convert(Expression.Call(
                    typeof(string).GetMethod("Concat", new[] { typeof(object), typeof(object) }),
                    Expression.Convert(exp, typeof(object)),
                    Expression.Constant(' ', typeof(object))
                ), typeof(object))
            );
        }

        private Expression BooleanSerializer(Expression exp)
        {
            var expbool = Expression.Convert(exp, typeof(bool?));
            return Expression.Condition(
                Expression.Equal(expbool, Expression.Constant(null, typeof(object))),
                Expression.Convert(exp, typeof(object)),
                Expression.Condition(
                    Expression.Equal(expbool, Expression.Constant(false, typeof(bool?))),
                    Expression.Constant(" 0", typeof(object)),
                    Expression.Constant(" 1", typeof(object))
                ));
        }

        private Dictionary<string, Delegate> packetSerializerDictionary = new Dictionary<string, Delegate>();

        private LambdaExpression PacketSerializerExpression<T>() where T : IPacket
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
                .Index;
            ParameterExpression param = Expression.Parameter(typeof(T));
            Expression serializedExp = Expression.Constant($"{header} ");
            foreach (var prop in properties)
            {
                var indexAttr = prop.GetCustomAttributes(true).OfType<PacketIndexAttribute>().First();
                Expression specificTypeExpression = Expression.Property(param, prop.Name);//default

                if (prop.PropertyType == typeof(bool) || prop.PropertyType == typeof(bool?)) //handle boolean
                {
                    specificTypeExpression = BooleanSerializer(specificTypeExpression);
                }

                if (prop.PropertyType == typeof(string)) //handle string
                {
                    specificTypeExpression = StringSerializer(specificTypeExpression, indexAttr.Index == maxIndex, indexAttr.IsOptional);
                }
                else if (Nullable.GetUnderlyingType(prop.PropertyType) != null) //handle null except string
                {
                    specificTypeExpression = NullableSerializer(specificTypeExpression, indexAttr.IsOptional);
                }

                serializedExp = Expression.Call(
                    typeof(string).GetMethod("Concat", new[] { typeof(object), typeof(object) }),
                    Expression.Convert(serializedExp, typeof(object)),
                    Expression.Convert(specificTypeExpression, typeof(object))
                );
            }
            return Expression.Lambda(serializedExp, param);
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
            var packetSerializerExpression = PacketSerializerExpression<T>();
            packetSerializerDictionary.Add(typeof(T).Name, packetSerializerExpression.Compile());
        }

        public string Serialize(IPacket packet)
        {
            var deg = packetSerializerDictionary[packet.GetType().Name];
            return (string)deg.DynamicInvoke(new[] { packet });
        }

        public string Serialize(IEnumerable<IPacket> packets)
        {
            throw new NotImplementedException();
        }
    }
}
