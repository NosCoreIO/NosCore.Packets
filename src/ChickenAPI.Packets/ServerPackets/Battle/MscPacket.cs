using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Battle
{
    [PacketHeader("ms_c")]
    public class MscPacket : PacketBase
    {
        [PacketIndex(0)]
        public long Unknown { get; set; } = 0;
    }
}