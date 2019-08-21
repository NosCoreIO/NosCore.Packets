using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Player
{
    [PacketHeader("rage")]
    public class RagePacket : PacketBase
    {
        [PacketIndex(0)]
        public long RagePoints { get; set; }

        [PacketIndex(1)]
        public long RagePointsMax { get; set; }
    }
}