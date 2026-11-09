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
    // The raid list board. Type tells the client which buttons to offer the reader.
    [PacketHeader("rl", Scope.InGame)]
    public class RaidListPacket : PacketBase
    {
        [PacketIndex(0)]
        public RaidListType Type { get; set; }

        [PacketListIndex(1)]
        public List<RaidListSubPacket?>? Raids { get; set; }
    }
}
