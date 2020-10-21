//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Inventory
{
    public class EquipmentSubPacket : PacketBase
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