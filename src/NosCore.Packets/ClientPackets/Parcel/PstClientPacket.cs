using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Parcel
{
    [PacketHeader("pst")]
    public class PstClientPacket : PacketBase
    {
        [PacketIndex(0)]
        public int ActionType { get; set; }

        [PacketIndex(1)]
        public int Type { get; set; }

        [PacketIndex(2)]
        public long Id { get; set; }

        [PacketIndex(3)]
        public int? Unknow1 { get; set; }

        [PacketIndex(4)]
        public int Unknow2 { get; set; }

        [PacketIndex(5)]
        public string? ReceiverName { get; set; }

        [PacketIndex(6, IsOptional = true)]
        public string? Title { get; set; }

        [PacketIndex(7, IsOptional = true)]
        public string? Text { get; set; }
    }
}
