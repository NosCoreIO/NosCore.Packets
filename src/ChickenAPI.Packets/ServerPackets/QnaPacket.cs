using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("qna")]
    public class QnaPacket : IPacket
    {
        [PacketIndex(0)]
        public IPacket YesPacket { get; set; }

        [PacketIndex(1)]
        public string Question { get; set; }
    }
}