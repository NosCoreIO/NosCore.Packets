//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.Benchmark.SaltyEmu
{
    /// <summary>
    ///     First version of a pluggable PacketFactory
    /// </summary>
    public class PluggablePacketFactory
    {
        private readonly Dictionary<string, Type> _packetTypesByHeader = new Dictionary<string, Type>();
        private readonly Dictionary<Type, PacketInformation> _deserializationInformations = new Dictionary<Type, PacketInformation>();


        public string Serialize(IPacket packet) => Serialize(packet, packet.GetType());

        public string Serialize<TPacket>(TPacket packet) where TPacket : IPacket =>
            Serialize(packet, typeof(TPacket));

        public string Serialize(IPacket packet, Type type)
        {
            try
            {
                // load pregenerated serialization information
                PacketInformation serializationInformation = GetSerializationInformation(type);

                var builder = new StringBuilder();
                builder.Append(serializationInformation.Header);

                int lastIndex = 0;

                foreach (PacketPropertyContainer property in serializationInformation.PacketProps!)
                {
                    PacketIndexAttribute? packetIndex = property.PacketIndex;
                    PropertyInfo? propertyType = property.PropertyInfo;
                    IEnumerable<ValidationAttribute?>? validations = property.Validations;
                    // check if we need to add a non mapped values (pseudovalues)
                    if (packetIndex!.Index > lastIndex + 1)
                    {
                        int amountOfEmptyValuesToAdd = packetIndex.Index - (lastIndex + 1);

                        for (int j = 0; j < amountOfEmptyValuesToAdd; j++)
                        {
                            builder.Append(" 0");
                        }
                    }

                    // add value for current configuration
                    builder.Append(SerializeValue(propertyType!.PropertyType, propertyType.GetValue(packet), validations, packetIndex));

                    // check if the value should be serialized to end
                    if (packetIndex.Index > serializationInformation.PacketProps.Length)
                    {
                        // we reached the end
                        break;
                    }

                    // set new index
                    lastIndex = packetIndex.Index;
                }

                return builder.ToString();
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }


        #region Serialization

        private string SerializeValue(Type? propertyType, object? value, IEnumerable<ValidationAttribute?>? validationAttributes, PacketIndexAttribute? packetIndexAttribute = null)
        {
            if (propertyType == null && validationAttributes.All(a => a!.IsValid(value)))
            {
                return string.Empty;
            }

            if (packetIndexAttribute?.IsOptional == true && string.IsNullOrEmpty(Convert.ToString(value)))
            {
                return string.Empty;
            }

            // check for nullable without value or string
            if (propertyType == typeof(string) && string.IsNullOrEmpty(Convert.ToString(value)))
            {
                return $"{packetIndexAttribute?.SpecialSeparator}-";
            }

            if (propertyType != null && Nullable.GetUnderlyingType(propertyType) != null && string.IsNullOrEmpty(Convert.ToString(value)))
            {
                return $"{packetIndexAttribute?.SpecialSeparator}-1";
            }

            // enum should be casted to number
            if (propertyType!.BaseType?.Equals(typeof(Enum)) == true)
            {
                return $"{packetIndexAttribute?.SpecialSeparator}{Convert.ToInt16(value)}";
            }

            if (propertyType == typeof(bool))
            {
                // bool is 0 or 1 not True or False
                return Convert.ToBoolean(value) ? $"{packetIndexAttribute?.SpecialSeparator}1" : $"{packetIndexAttribute?.SpecialSeparator}0";
            }

            if (value is IPacket)
            {
                PacketInformation subpacketSerializationInfo = GetSerializationInformation(value.GetType());
                return SerializeSubpacket(value, subpacketSerializationInfo, packetIndexAttribute?.IsOptional ?? false);
            }

            if (propertyType.BaseType?.Equals(typeof(IPacket)) == true)
            {
                PacketInformation subpacketSerializationInfo = GetSerializationInformation(propertyType);
                return SerializeSubpacket(value, subpacketSerializationInfo, packetIndexAttribute?.IsOptional ?? false);
            }

            if (propertyType.IsGenericType && propertyType.GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>))
                && propertyType.GenericTypeArguments[0].BaseType == typeof(IPacket))
            {
                return packetIndexAttribute?.SpecialSeparator + SerializeSubpackets((IList?)value, propertyType);
            }

            if (propertyType.IsGenericType && propertyType.GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>))) //simple list
            {
                return packetIndexAttribute?.SpecialSeparator + SerializeSimpleList((IList?)value, propertyType, packetIndexAttribute);
            }

            return $"{packetIndexAttribute?.SpecialSeparator}{value}";
        }

        private string SerializeSimpleList(IList? listValues, Type propertyType, PacketIndexAttribute? index)
        {
            string resultListPacket = string.Empty;
            int listValueCount = listValues?.Count ?? 0;
            if (listValueCount <= 0)
            {
                return resultListPacket;
            }

            resultListPacket += SerializeValue(propertyType.GenericTypeArguments[0], listValues![0], propertyType.GenericTypeArguments[0].GetCustomAttributes<ValidationAttribute>());

            for (int i = 1; i < listValueCount; i++)
            {
                resultListPacket +=
                    $"{index!.SpecialSeparator}{SerializeValue(propertyType.GenericTypeArguments[0], listValues[i], propertyType.GenericTypeArguments[0].GetCustomAttributes<ValidationAttribute>()).Replace(" ", "")}";
            }

            return resultListPacket;
        }

        private string SerializeSubpacket(object? value, PacketInformation subpacketSerializationInfo, bool isReturnPacket)
        {
            string serializedSubpacket = isReturnPacket ? $" #{subpacketSerializationInfo.Header}^" : " ";

            // iterate thru configure subpacket properties
            foreach (PacketPropertyContainer tmp in subpacketSerializationInfo.PacketProps!)
            {
                PacketIndexAttribute key = tmp.PacketIndex!;
                PropertyInfo propertyInfo = tmp.PropertyInfo!;
                // first element
                if (key.Index != 0)
                {
                    serializedSubpacket += isReturnPacket ? "^" : key.SpecialSeparator;
                }

                serializedSubpacket += SerializeValue(propertyInfo.PropertyType, propertyInfo.GetValue(value), tmp.Validations, key).Replace(" ", "");
            }

            return serializedSubpacket;
        }

        private PacketInformation GenerateSerializationInformations(Type serializationType)
        {
            string? header = serializationType.GetCustomAttribute<PacketHeaderAttribute>()?.Identification;

            if (string.IsNullOrEmpty(header))
            {
                throw new Exception($"Packet header cannot be empty. PacketType: {serializationType.Name}");
            }

            Dictionary<PacketIndexAttribute, PropertyInfo> packetsForPacketDefinition = new Dictionary<PacketIndexAttribute, PropertyInfo>();

            IEnumerable<PropertyInfo> packetIndexProperties = serializationType.GetProperties().Where(x => x.GetCustomAttributes(false).OfType<PacketIndexAttribute>().Any()).ToArray();


            List<PacketPropertyContainer> packetProperties =
                (from packetBasePropertyInfo in packetIndexProperties.OrderBy(s => s.GetCustomAttribute<PacketIndexAttribute>(false)!.Index)
                 let indexAttribute = packetBasePropertyInfo.GetCustomAttributes(false).OfType<PacketIndexAttribute>().FirstOrDefault()
                 where indexAttribute != null
                 select new PacketPropertyContainer
                 {
                     PacketIndex = indexAttribute, PropertyInfo = packetBasePropertyInfo,
                     Validations = packetBasePropertyInfo.GetCustomAttributes<ValidationAttribute>()
                 }).ToList();

            var tmp = new PacketInformation
            {
                Type = serializationType,
                Header = header,
                PacketProps = packetProperties.OrderBy(container => container.PacketIndex!.Index).ToArray()
            };

            if (!_packetTypesByHeader.ContainsKey(tmp.Header))
            {
                _packetTypesByHeader.Add(tmp.Header, serializationType);
            }

            _deserializationInformations.Add(serializationType, tmp);

            return tmp;
        }

        private PacketInformation GetSerializationInformation(Type serializationType)
        {
            if (_deserializationInformations.TryGetValue(serializationType, out PacketInformation? packetInfo))
            {
                return packetInfo;
            }

            return GenerateSerializationInformations(serializationType);
        }

        private string SerializeSubpackets(ICollection? listValues, Type packetBasePropertyType)
        {
            string serializedSubPacket = string.Empty;
            PacketInformation subpacketSerializationInfo = GetSerializationInformation(packetBasePropertyType.GetGenericArguments()[0]);

            if (listValues?.Count > 0)
            {
                serializedSubPacket = listValues.Cast<object>().Aggregate(serializedSubPacket,
                    (current, listValue) => current + SerializeSubpacket(listValue, subpacketSerializationInfo, false));
            }

            return serializedSubPacket;
        }

        #endregion
    }
}