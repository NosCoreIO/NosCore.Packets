using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.ServerPackets.Inventory;

namespace NosCore.Packets.ServerPackets.Warehouse
{
    [PacketHeader("f_stash")]
    public class FStashClientPacket : PacketBase
    {
        [PacketIndex(0)]
        public List<IvnSubPacket?>? IvnSubPackets { get; set; }
    }
}