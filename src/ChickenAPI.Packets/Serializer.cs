﻿using System;
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

        private readonly Dictionary<string, Delegate> packetSerializerDictionary = new Dictionary<string, Delegate>();


        public Serializer(IEnumerable<Type> types)
        {
            var serializerMethod = typeof(Serializer).GetMethod(nameof(Initialize));
            foreach (var type in types)
            {
                serializerMethod.MakeGenericMethod(type).Invoke(this, null);
            }
        }

        public void Initialize<T>() where T : PacketBase
        {
            var packetSerializerExpressionFalse = PacketSerializerExpression<T>();
            if(packetSerializerExpressionFalse != null && !packetSerializerDictionary.ContainsKey(typeof(T).Name))
            {
                packetSerializerDictionary.Add(typeof(T).Name, packetSerializerExpressionFalse.Compile());
            }
        }

        public string Serialize(IPacket packet)
        {
            var realType = packet.GetType();
            var deg = packetSerializerDictionary[packet.GetType().Name];
            var fullString = (string)deg.DynamicInvoke(packet, false);
            if (fullString.Contains(INJECTION_KEY))
            {
                //unfortunately some packets like DLG, DELAY can handle multiple type packet we can't build the full serializer at init, instead we inject serializer with reflection
                foreach (var prop in realType.GetProperties().Where(p => p.PropertyType == typeof(IPacket)))
                {
                    var Place = fullString.IndexOf(INJECTION_KEY);
                    var value = realType.GetProperty(prop.Name).GetValue(packet, null);
                    fullString = fullString
                        .Remove(Place, INJECTION_KEY.Length)
                        .Insert(Place,
                            (string)packetSerializerDictionary[value.GetType().Name].DynamicInvoke(value, true));
                }
            }

            return fullString;
        }

        public string Serialize(IEnumerable<IPacket> packets)
        {
           return string.Join('\uffff'.ToString(), packets.Select(Serialize));
        }

        private Expression DefaultSerializer(Expression specificTypeExpression, Expression splitter)
        {
            return ConcatExpression(splitter, specificTypeExpression);
        }

        private Expression StringSerializer(Expression exp, bool isLastIndex, bool isOptional, Expression splitter)
        {
            var replace = Expression.Call(exp,
                typeof(string).GetMethod("Replace", new[] { typeof(string), typeof(string) }),
                Expression.Convert(splitter, typeof(string)),
                Expression.Constant("^", typeof(string))
            );

            var nullOrEmpty = Expression.Call(null,
                typeof(string).GetMethod("IsNullOrEmpty", new[] { typeof(string) }),
                Expression.Convert(splitter, typeof(string))
            );

            return Expression.Condition(
                Expression.Equal(exp, Expression.Constant(null, typeof(object))),
               isOptional ? Expression.Constant(null) : ConcatExpression(splitter, Expression.Constant("-")),
                ConcatExpression(splitter,
                    Expression.Condition(nullOrEmpty,
                        Expression.Convert(exp, typeof(object)),
                        Expression.Convert(isLastIndex ? exp : replace, typeof(object))))
            );
        }

        private Expression NullableSerializer(Expression exp, bool isOptional, Expression splitter)
        {
            return Expression.Condition(
                Expression.Equal(exp, Expression.Constant(null, typeof(object))),
                isOptional ? Expression.Constant(null, typeof(object))
                    : ConcatExpression(splitter, Expression.Constant("-1")),
                ConcatExpression(splitter, exp)
            );
        }

        private Expression EnumSerializer(Expression exp, Expression splitter)
        {
            var expObject = Expression.Convert(Expression.Convert(exp, typeof(long?)), typeof(object));
            return Expression.Condition(
                Expression.Equal(expObject, Expression.Default(typeof(object))),
                expObject,
                ConcatExpression(splitter, expObject));
        }

        private Expression ConcatExpression(Expression left, Expression right)
        {
            return Expression.Convert(Expression.Call(
                typeof(string).GetMethod("Concat", new[] { typeof(object), typeof(object) }),
                Expression.Convert(left, typeof(object)),
                Expression.Convert(right, typeof(object))), typeof(object));
        }

        private Expression BooleanSerializer(Expression exp, Expression splitter)
        {
            var falseSplitter = ConcatExpression(splitter, Expression.Constant("0"));

            var trueSplitter = ConcatExpression(splitter, Expression.Constant("1"));

            var expbool = Expression.Convert(exp, typeof(bool?));

            var isFalse = Expression.Condition(
                Expression.Equal(expbool, Expression.Constant(false, typeof(bool?))),
                falseSplitter,
                trueSplitter
                , typeof(object));

            return Expression.Condition(Expression.Equal(expbool, Expression.Constant(null, typeof(object))),
                Expression.Convert(exp, typeof(object)),
                isFalse);
        }

        private Expression ListSerializer(Expression injectedPacket, Expression specificTypeExpression,
            PacketIndexAttribute indexAttr, Type type, string packetSplitter, Expression propertySplitter)
        {
            var param = Expression.Parameter(type.GenericTypeArguments[0]);
            if (typeof(IPacket).IsAssignableFrom(type.GenericTypeArguments[0]))
            {
                indexAttr.IsOptional = false;
            }

            var selectExp = Expression.Call(
            typeof(Enumerable),
            "Select",
            new[] { type.GenericTypeArguments[0], typeof(string) },
            specificTypeExpression,
            Expression.Lambda(
                Expression.Convert(typeof(IPacket).IsAssignableFrom(type.GenericTypeArguments[0]) ?
                    IPacketSerializer(injectedPacket, indexAttr, param, type.GenericTypeArguments[0], 0, propertySplitter, "") :
                    PropertySerializer(injectedPacket, indexAttr, type.GenericTypeArguments[0], param, 0,
                        Expression.Constant("")), typeof(string)), param)
            );

            var listJoin = Expression.Convert(Expression.Call(
                typeof(string).GetMethod("Join", new[] { typeof(string), typeof(IEnumerable<string>) }),
                Expression.Constant(packetSplitter, typeof(string)),
                selectExp), typeof(object));

            return Expression.Condition(
                Expression.Equal(specificTypeExpression, Expression.Constant(null, typeof(object))),
                Expression.Constant(null, typeof(object)),
                Expression.Convert(listJoin, typeof(object))
            );
        }

        private Expression IPacketSerializer(Expression injectedPacket, PacketIndexAttribute indexAttr, Expression specificTypeExpression, Type prop,
            int maxIndex, Expression propertySplitter, string discriminator)
        {
            var properties = prop.GetProperties()
                .Where(x => x.GetCustomAttributes(true).OfType<PacketIndexAttribute>().Any())
                .OrderBy(x => x.GetCustomAttributes(true).OfType<PacketIndexAttribute>().First().Index).ToList();

            Expression propExp = Expression.Condition(injectedPacket, Expression.Constant($"#{discriminator}"),
                Expression.Constant(discriminator, typeof(string)));

            var i = 0;
            foreach (var property in properties)
            {
                var index = property.GetCustomAttributes(true).OfType<PacketIndexAttribute>().First();
                var exp = Expression.Convert(
                    PropertySerializer(injectedPacket,
                        index,
                        property.PropertyType,
                        Expression.Property(specificTypeExpression, property.Name),
                        maxIndex,
                        Expression.Condition(injectedPacket, Expression.Constant("^", typeof(object)),
                            Expression.Constant(index.SpecialSeparator, typeof(object))))
                    , typeof(object));

                var removesplitter =
                    (i == 0) && string.IsNullOrWhiteSpace(discriminator) && (index.SpecialSeparator == null);

                var splitter = Expression.Condition(injectedPacket,
                    Expression.Constant(string.Empty, typeof(object)),
                    removesplitter || ((index.SpecialSeparator != null) && (i != 0))
                        ? Expression.Constant(string.Empty, typeof(object))
                        : (Expression)Expression.Convert(propertySplitter, typeof(object)));

                var trimnull = Expression.Condition(
                    Expression.Equal(exp, Expression.Constant(null, typeof(object))),
                    Expression.Constant(string.Empty, typeof(object)),
                    ConcatExpression(splitter, exp));

                propExp = ConcatExpression(propExp, trimnull);
                i++;
            }

            return Expression.Condition(
                Expression.Equal(specificTypeExpression, Expression.Constant(null, typeof(object))),
                Expression.Constant(indexAttr.IsOptional ? null : "-1", typeof(object)),
                Expression.Convert(propExp, typeof(object))
            );
        }

        private LambdaExpression PacketSerializerExpression<T>() where T : PacketBase
        {
            var header = typeof(T).GetCustomAttribute<PacketHeaderAttribute>()?.Identification;

            if (string.IsNullOrEmpty(header))
            {
                return null;
            }

            var properties = typeof(T).GetProperties()
                .Where(x => x.GetCustomAttributes(true).OfType<PacketIndexAttribute>().Any())
                .OrderBy(x => x.GetCustomAttributes(true).OfType<PacketIndexAttribute>().First().Index).ToList();
            var maxIndex = properties.LastOrDefault()?.GetCustomAttributes(true).OfType<PacketIndexAttribute>().First()
                .Index ?? 0;
            var param = Expression.Parameter(typeof(T));
            var injectedPacket = Expression.Parameter(typeof(bool));
            return Expression.Lambda(
                Expression.Convert(
                    IPacketSerializer(injectedPacket, new PacketIndexAttribute(0), param, typeof(T), maxIndex, Expression.Constant(" "), header),
                    typeof(object)), param, injectedPacket);
        }

        private Expression PropertySerializer(Expression injectedPacket, PacketIndexAttribute indexAttr, Type type,
            Expression specificTypeExpression, int maxIndex, Expression propertySplitter)
        {
            var useCustomSerializer = true;
            switch (type)
            {
                //handle boolean
                case var t when (t == typeof(bool)) || (t == typeof(bool?)):
                    specificTypeExpression = BooleanSerializer(specificTypeExpression, propertySplitter);
                    break;
                //handle enum
                case var t when (t.BaseType?.Equals(typeof(Enum)) ?? false) ||
                    (Nullable.GetUnderlyingType(t)?.IsEnum ?? false):
                    specificTypeExpression = EnumSerializer(specificTypeExpression, propertySplitter);
                    break;
                //handle list
                case var t when t.IsGenericType && t.GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>)):
                    specificTypeExpression = ListSerializer(injectedPacket, specificTypeExpression, indexAttr, t, " ",
                        Expression.Constant(typeof(IPacket).IsAssignableFrom(t.GenericTypeArguments[0])
                            ? indexAttr.SpecialSeparator ?? "." : " "));
                    break;
                //handle string
                case var t when t == typeof(string):
                    specificTypeExpression = StringSerializer(specificTypeExpression, indexAttr.Index == maxIndex,
                        indexAttr.IsOptional, propertySplitter);
                    break;
                //IPacket declared type
                case var t when typeof(IPacket).IsAssignableFrom(t) && (t != typeof(IPacket)):
                    var header = specificTypeExpression.Type.GetCustomAttribute<PacketHeaderAttribute>()
                        ?.Identification;
                    propertySplitter = Expression.Constant(indexAttr.SpecialSeparator ?? (header == null ? " " : "."));
                    if (!string.IsNullOrEmpty(header))
                    {
                        header = $"#{header}";
                        propertySplitter = Expression.Constant("^");
                    }

                    if (header == null && indexAttr.SpecialSeparator != null)
                    {
                        header = " ";
                    }

                    specificTypeExpression = IPacketSerializer(injectedPacket, indexAttr, specificTypeExpression, t, maxIndex,
                        propertySplitter, header);
                    break;
                case var t when t == typeof(IPacket):
                    specificTypeExpression = Expression.Constant(INJECTION_KEY, typeof(string));
                    break;
                default:
                    useCustomSerializer = false;
                    break;
            }

            if ((type != typeof(string)) && (Nullable.GetUnderlyingType(type) != null))
            {
                specificTypeExpression =
                    NullableSerializer(specificTypeExpression, indexAttr.IsOptional, propertySplitter);
                useCustomSerializer = true;
            }

            if (!useCustomSerializer)
            {
                specificTypeExpression = DefaultSerializer(specificTypeExpression, propertySplitter);
            }

            return specificTypeExpression;
        }
    }
}