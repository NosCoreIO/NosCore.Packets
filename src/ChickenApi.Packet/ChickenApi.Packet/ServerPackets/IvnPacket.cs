using System.Collections.Generic;
using ChickenApi.Packet.Enumerations;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("ivn")]
    public class IvnPacket : IPacket
    {
        [PacketIndex(0)]
        public PocketType Type { get; set; }

        [PacketIndex(1)]
        public List<IvnSubPacket> IvnSubPackets { get; set; }
    }
}