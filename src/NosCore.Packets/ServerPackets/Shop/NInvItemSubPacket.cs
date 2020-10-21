//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Shop
{
    [PacketHeader("n_inv_item", Scope.InGame)]
    public class NInvItemSubPacket : PacketBase
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