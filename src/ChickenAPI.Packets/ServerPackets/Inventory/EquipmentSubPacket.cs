using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Inventory
{
    public class EquipmentSubPacket : IPacket
    {
        [PacketIndex(0)]
        public EquipmentType EquipmentType { get; set; }

        [PacketIndex(1)]
        public short? VNum { get; set; }

        [PacketIndex(2)]
        public short Rare { get; set; }

        [PacketIndex(3)]
        public short Upgrade { get; set; }

        [PacketIndex(4)]
        public byte Unknown { get; set; }
    }
}