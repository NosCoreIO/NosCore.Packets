//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.ServerPackets.Inventory;

namespace NosCore.Packets.ServerPackets.Warehouse
{
    [PacketHeader("stash")]
    public class StashClientPacket : PacketBase, IWorldPacket
    {
        [PacketListIndex(0)]
        public List<IvnSubPacket?>? IvnSubPackets { get; set; }
    }
}