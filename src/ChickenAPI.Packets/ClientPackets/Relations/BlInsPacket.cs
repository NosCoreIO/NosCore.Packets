using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Relations
{
    [PacketHeader("blins")]
    public class BlInsPacket : PacketBase
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }
    }
}