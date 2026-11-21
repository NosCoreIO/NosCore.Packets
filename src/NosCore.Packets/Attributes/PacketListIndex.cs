//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;

namespace NosCore.Packets.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class PacketListIndexAttribute : PacketIndexAttribute
    {
        public PacketListIndexAttribute(int index) : base(index)
        {
        }

        public string? ListSeparator { get; set; }
        public sbyte Length { get; set; }

        // A list whose items are all absent ends with its separator ("-1.-1.-1.").
        public bool TrailingSeparatorWhenAllAbsent { get; set; }
    }
}