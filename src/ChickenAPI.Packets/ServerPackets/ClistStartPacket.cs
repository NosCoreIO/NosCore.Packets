using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("clist_start")]
    public class ClistStartPacket : IPacket
    {
        [PacketIndex(0)]
        public byte Type { get; set; }
    }
}