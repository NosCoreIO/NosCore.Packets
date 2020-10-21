//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Player
{
    [PacketHeader("up_gr", Scope.InGame)]
    public class UpgradePacket : PacketBase
    {
        [PacketIndex(0)]
        public UpgradePacketType UpgradeType { get; set; }

        [PacketIndex(1)]
        public PocketType InventoryType { get; set; }

        [PacketIndex(2)]
        public byte Slot { get; set; }

        [PacketIndex(3, IsOptional = true)]
        public PocketType? InventoryType2 { get; set; }

        [PacketIndex(4, IsOptional = true)]
        public byte? Slot2 { get; set; }

        [PacketIndex(5, IsOptional = true)]
        public PocketType? CellonInventoryType { get; set; }

        [PacketIndex(6, IsOptional = true)]
        public byte? CellonSlot { get; set; }

    }
}