using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.ServerPackets.Inventory;

namespace NosCore.Packets.ServerPackets.Warehouse
{
    [PacketHeader("stash")]
    public class StashClientPacket : PacketBase
    {
        [PacketIndex(0)]
        public List<IvnSubPacket?>? IvnSubPackets { get; set; }
    }
}