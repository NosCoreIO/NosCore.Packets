using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Parcel
{
    public class ParcelAttachmentSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte TitleType { get; set; }

        [PacketIndex(1)]
        public byte Unknown2 { get; set; }

        [PacketIndex(2)]
        public string? Date { get; set; }

        [PacketIndex(3)]
        public string? Title { get; set; }

        [PacketIndex(4)]
        public short AttachmentVNum { get; set; }

        [PacketIndex(5)]
        public short AttachmentAmount { get; set; }

        [PacketIndex(6)]
        public short ItemType { get; set; }
    }
}