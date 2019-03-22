using ChickenApi.Packet.Enumerations;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("in")]
    public class InPacket : IPacket
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1, IsOptional = true)]
        public string Name { get; set; }

        [PacketIndex(2)]
        public string VNum { get; set; }

        [PacketIndex(3)]
        public long VisualId { get; set; }

        [PacketIndex(4)]
        public short PositionX { get; set; }

        [PacketIndex(5)]
        public short PositionY { get; set; }

        [PacketIndex(6, IsOptional = true)]
        public byte? Direction { get; set; }

        [PacketIndex(7, IsOptional = true, SpecialSeparator = " ")]
        public InCharacterSubPacket InCharacterSubPacket { get; set; }

        [PacketIndex(8, IsOptional = true, SpecialSeparator = " ")]
        public InItemSubPacket InItemSubPacket { get; set; }

        [PacketIndex(9, IsOptional = true, SpecialSeparator = " ")]
        public InNonPlayerSubPacket InNonPlayerSubPacket { get; set; }
    }
}