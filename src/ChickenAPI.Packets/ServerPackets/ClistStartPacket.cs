using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("clist_start")]
    public class ClistStartPacket : IPacket
    {
        [PacketIndex(0)]
        public byte Type { get; set; }
    }
}