using System;

namespace ChickenAPI.Packets.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class PacketIndexAttribute : Attribute
    {
        public PacketIndexAttribute(int index)
        {
            Index = index;
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