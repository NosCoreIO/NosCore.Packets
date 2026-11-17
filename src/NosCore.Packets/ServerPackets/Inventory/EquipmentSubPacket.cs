//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Inventory
{
    public class EquipmentSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public EquipmentType EquipmentType { get; set; }

        public short? VNum { get; set; }

        public bool IsLimited { get; set; }

        [PacketIndex(1)]
        public short? WireVNum
        {
            get => VNum is { } vnum ? LimitedItem.ToWire(vnum, IsLimited) : null;
            set
            {
                VNum = value is { } wire ? LimitedItem.VNum(wire) : null;
                IsLimited = value is { } limited && LimitedItem.IsLimited(limited);
            }
        }

        [PacketIndex(2)]
        public short Rare { get; set; }

        [PacketIndex(3)]
        public short Upgrade { get; set; }

        [PacketIndex(4)]
        public byte Unknown { get; set; }

        [PacketIndex(5)]
        public byte Unknown1 { get; set; }

        [PacketIndex(6)]
        public byte Unknown2 { get; set; }
    }
}