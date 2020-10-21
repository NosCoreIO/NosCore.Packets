//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Inventory
{
    [PacketHeader("ivn", Scope.InGame)]
    public class IvnPacket : PacketBase
    {
        [PacketIndex(0)]
        public PocketType Type { get; set; }

        [PacketListIndex(1)]
        public List<IvnSubPacket?>? IvnSubPackets { get; set; }
    }
}