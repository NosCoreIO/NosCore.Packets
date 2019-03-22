using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Enumerations;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("n_inv_item")]
    public class NInvItemSubPacket : IPacket
    {
        [PacketIndex(0)]
        public PocketType Type { get; set; }

        [PacketIndex(1)]
        public short Slot { get; set; }

        [PacketIndex(2)]
        public short VNum { get; set; }

        [PacketIndex(3)]
        public short? RareAmount { get; set; }

        [PacketIndex(4, IsOptional = true)]
        public short? UpgradeDesign { get; set; }

        [PacketIndex(5)]
        public int Price { get; set; }
    }
}