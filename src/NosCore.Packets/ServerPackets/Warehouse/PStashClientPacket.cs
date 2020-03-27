using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.ServerPackets.Inventory;

namespace NosCore.Packets.ServerPackets.Warehouse
{
    [PacketHeader("p_stash")]
    public class PStashClientPacket : PacketBase
    {
        [PacketIndex(0)]
        public List<IvnSubPacket?>? IvnSubPackets { get; set; }
    }
}