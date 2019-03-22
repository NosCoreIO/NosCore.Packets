using System;

namespace ChickenApi.Packet
{
    [AttributeUsage(AttributeTargets.All)]
    public class PacketIndexAttribute : Attribute
    {
        public PacketIndexAttribute(int index) : this(index, false, false, false, ".")
        {
        }

        public PacketIndexAttribute(int index, bool isReturnPacket, bool serializeToEnd,
            bool removeSeparator) : this(index, isReturnPacket, serializeToEnd, removeSeparator, ".")
        {
        }

        public PacketIndexAttribute(int index, bool isReturnPacket, bool serializeToEnd,
            bool removeSeparator, string specialSeparator)
        {
            Index = index;
            IsReturnPacket = isReturnPacket;
            SerializeToEnd = serializeToEnd;
            SpecialSeparator = specialSeparator;
        }

        public int Index { get; set; }

        public bool IsReturnPacket { get; set; }

        public bool SerializeToEnd { get; set; }

        public bool IsOptional { get; set; }

        public string SpecialSeparator { get; set; }

        public sbyte Length { get; set; }
    }
}