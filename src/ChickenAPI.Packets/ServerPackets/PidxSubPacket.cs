using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("pidx_sub_packet")]
    public class PidxSubPacket : IPacket
    {
        [PacketIndex(0)]
        public bool IsGrouped { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }
    }
}