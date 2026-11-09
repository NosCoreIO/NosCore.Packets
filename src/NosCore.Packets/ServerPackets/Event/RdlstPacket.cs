//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Event
{
    // The raid party window: the raid's level range, then one entry per member.
    [PacketHeader("rdlst", Scope.InGame)]
    public class RdlstPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte MinimumLevel { get; set; }

        [PacketIndex(1)]
        public byte MaximumLevel { get; set; }

        [PacketIndex(2)]
        public byte RaidType { get; set; }

        [PacketListIndex(3)]
        public List<RdlstSubPacket?>? Members { get; set; }
    }
}
