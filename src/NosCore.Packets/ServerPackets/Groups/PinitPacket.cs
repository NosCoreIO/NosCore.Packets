//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Groups
{
    [PacketHeader("pinit", Scope.InGame)]
    public class PinitPacket : PacketBase
    {
        [PacketIndex(0)]
        public int GroupSize { get; set; }

        [PacketListIndex(1, SpecialSeparator = "|")]
        public List<PinitSubPacket?>? PinitSubPackets { get; set; }
    }
}