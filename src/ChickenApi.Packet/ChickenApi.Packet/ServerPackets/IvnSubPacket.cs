namespace ChickenApi.Packet.ServerPackets
{
    public class IvnSubPacket : IPacket
    {
        [PacketIndex(0)]
        public short Slot { get; set; }

        [PacketIndex(1)]
        public short VNum { get; set; }

        [PacketIndex(2)]
        public short RareAmount { get; set; }

        [PacketIndex(3)]
        public short UpgradeDesign { get; set; }

        [PacketIndex(4)]
        public byte SecondUpgrade { get; set; }
    }
}