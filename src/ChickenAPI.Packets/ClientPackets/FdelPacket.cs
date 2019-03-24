using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets
{
    [PacketHeader("fdel")]
    public class FdelPacket : IPacket
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }
    }
}