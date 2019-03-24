using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets
{
    [PacketHeader("btk")]
    public class BtkPacket : IPacket
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }

        [PacketIndex(1)]
        public string Message { get; set; }
    }
}