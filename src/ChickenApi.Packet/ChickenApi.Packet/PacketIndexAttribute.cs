using System;

namespace ChickenApi.Packet
{
    [AttributeUsage(AttributeTargets.All)]
    public class PacketIndexAttribute : Attribute
    {
        public PacketIndexAttribute(int index) : this(index, false, ".")
        {
        }

        public PacketIndexAttribute(int index, bool serializeToEnd) : this(index, serializeToEnd, ".")
        {
        }

        public PacketIndexAttribute(int index, bool serializeToEnd, string specialSeparator)
        {
            Index = index;
            SerializeToEnd = serializeToEnd;
            SpecialSeparator = specialSeparator;
        }

        public int Index { get; set; }

        public bool SerializeToEnd { get; set; }

        public bool IsOptional { get; set; }

        public string SpecialSeparator { get; set; }

        public sbyte Length { get; set; }
    }
}