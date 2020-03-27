using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Parcel
{
    [PacketHeader("post")]
    public class PostPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1)]
        public byte PostType { get; set; }

        [PacketIndex(2)]
        public short Id { get; set; }

        [PacketIndex(3)]
        public short Unknown { get; set; }

        [PacketIndex(4)]
        public bool IsOpened { get; set; }

        [PacketIndex(5, IsOptional = true)]
        public PostSubPacket? PostSubPacket { get; set; }

        [PacketIndex(6, IsOptional = true)]
        public string? DateTime { get; set; }

        [PacketIndex(7)]
        public string? SenderName { get; set; }

        [PacketIndex(8)]
        public string? Title { get; set; }

        [PacketIndex(9, IsOptional = true)]
        public string? Message { get; set; }
    }
}