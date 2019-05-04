using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Inventory
{
    public class UpgradeRareSubPacket : PacketBase
    {
        [PacketIndex(0, IsOptional = true)]
        public byte? Upgrade { get; set; }

        [PacketIndex(1)]
        public sbyte Rare { get; set; }
    }
}
