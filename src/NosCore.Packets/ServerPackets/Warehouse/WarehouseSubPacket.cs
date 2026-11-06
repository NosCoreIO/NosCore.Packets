//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Warehouse
{
    // A specialist card puts its upgrade in Amount and its stone upgrade in Rare.
    public class WarehouseSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Slot { get; set; }

        [PacketIndex(1)]
        public short VNum { get; set; }

        [PacketIndex(2)]
        public PocketType Type { get; set; }

        [PacketIndex(3)]
        public short Amount { get; set; }

        [PacketIndex(4)]
        public short Rare { get; set; }

        [PacketIndex(5)]
        public byte Upgrade { get; set; }
    }
}
