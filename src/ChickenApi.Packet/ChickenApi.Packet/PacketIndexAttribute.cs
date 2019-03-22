using System;

namespace ChickenApi.Packet
{
    [AttributeUsage(AttributeTargets.All)]
    public class PacketIndexAttribute : Attribute
    {
        public PacketIndexAttribute(int index) : this(index, ".")
        {
        }

        public PacketIndexAttribute(int index, string specialSeparator)
        {
            Index = index;
            SpecialSeparator = specialSeparator;
        }

        public int Index { get; set; }

        public bool IsOptional { get; set; }

        public string SpecialSeparator { get; set; }

        public sbyte Length { get; set; }
    }
}