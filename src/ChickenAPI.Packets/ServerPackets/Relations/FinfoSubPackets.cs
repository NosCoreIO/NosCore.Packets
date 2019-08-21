using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Relations
{
    [PacketHeader("finfo_sub_packets")]
    public class FinfoSubPackets : PacketBase
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }

        [PacketIndex(1)]
        public bool IsConnected { get; set; }
    }
}