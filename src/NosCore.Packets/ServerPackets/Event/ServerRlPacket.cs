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
    // The raid listing board: one entry per team looking for members.
    [PacketHeader("rl", Scope.InGame)]
    public class ServerRlPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Mode { get; set; }

        [PacketListIndex(1)]
        public List<ServerRlSubPacket?>? Teams { get; set; }
    }
}
