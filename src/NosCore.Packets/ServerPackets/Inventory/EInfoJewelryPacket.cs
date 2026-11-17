//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Inventory
{
    // Answer to eqinfo for a ring, a necklace or a bracelet, with its cellon options.
    [PacketHeader("e_info", Scope.InGame, AllowDuplicateHeader = true)]
    public class EInfoJewelryPacket : PacketBase
    {
        [PacketIndex(0)]
        public EInfoPacketType Type { get; set; } = EInfoPacketType.Jewelery;

        public short ItemVNum { get; set; }

        public bool IsLimited { get; set; }

        [PacketIndex(1)]
        public short WireItemVNum
        {
            get => LimitedItem.ToWire(ItemVNum, IsLimited);
            set
            {
                ItemVNum = LimitedItem.VNum(value);
                IsLimited = LimitedItem.IsLimited(value);
            }
        }

        [PacketIndex(2)]
        public byte LevelMinimum { get; set; }

        [PacketIndex(3)]
        public byte MaxCellonLevel { get; set; }

        [PacketIndex(4)]
        public byte MaxCellon { get; set; }

        [PacketIndex(5)]
        public byte CellonOptionCount { get; set; }

        [PacketIndex(6)]
        public long Price { get; set; }

        [PacketListIndex(7, SpecialSeparator = " ", IsOptional = true)]
        public List<EInfoCellonOptionSubPacket>? CellonOptions { get; set; }
    }
}
