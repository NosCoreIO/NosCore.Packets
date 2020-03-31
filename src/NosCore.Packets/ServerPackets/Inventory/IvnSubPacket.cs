using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Inventory
{
    public class IvnSubPacket : PacketBase
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