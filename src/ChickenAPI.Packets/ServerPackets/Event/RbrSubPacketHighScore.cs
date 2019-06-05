using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Event
{
    public class RbrSubPacketHighScore : PacketBase
    {
        [PacketIndex(0)]
        public short Score { get; set; }

        [PacketIndex(1, IsOptional = true)]
        public string Nickname { get; set; }
    }
}