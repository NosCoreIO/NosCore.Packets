using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Families
{
    [PacketHeader("gjoin")]
    public class JoinFamilyPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1)]
        public long CharacterId { get; set; }
    }
}