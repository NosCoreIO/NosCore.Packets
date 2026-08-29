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

        /// <summary>
        ///     Encode spaces as "^" even when nothing would break without it. The last field of a
        ///     packet keeps its spaces by default, which is what chat lines need; a few fields
        ///     carry text the client expects "^"-encoded regardless of where they sit.
        /// </summary>
        public bool EscapeSpaces { get; set; }
    }
}