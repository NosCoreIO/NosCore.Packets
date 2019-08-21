using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Shop
{
    [PacketHeader("pidx_sub_packet")]
    public class PidxSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public bool IsGrouped { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }
    }
}