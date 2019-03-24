using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets
{
    [PacketHeader("glist")]
    public class GListPacket : IPacket
    {
        [PacketIndex(1)]
        public byte Type { get; set; }
    }
}