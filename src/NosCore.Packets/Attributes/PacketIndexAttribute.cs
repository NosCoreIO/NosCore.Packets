//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;

namespace NosCore.Packets.Attributes
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

        public string? SpecialSeparator { get; set; }

        public bool RemoveHeader { get; set; }

        public bool RemoveHash { get; set; }
    }
}