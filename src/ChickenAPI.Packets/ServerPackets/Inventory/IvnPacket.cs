using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ServerPackets.Inventory
{
    [PacketHeader("ivn")]
    public class IvnPacket : PacketBase
    {
        [PacketIndex(0)]
        public PocketType Type { get; set; }

        [PacketIndex(1)]
        public List<IvnSubPacket> IvnSubPackets { get; set; }
    }
}