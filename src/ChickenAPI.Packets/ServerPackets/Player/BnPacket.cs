using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Player
{
    [PacketHeader("bn")]
    public class BnPacket : IPacket
    {
        [PacketIndex(0)]
        public byte BnNumber { get; set; }

        [PacketIndex(1)]
        public string Message { get; set; }
    }
}