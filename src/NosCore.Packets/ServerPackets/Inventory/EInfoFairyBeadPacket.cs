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
    // Answer to eqinfo for a fairy bead. The fairy and its element rate are only sent when it holds one.
    [PacketHeader("e_info", Scope.InGame, AllowDuplicateHeader = true)]
    public class EInfoFairyBeadPacket : PacketBase
    {
        [PacketIndex(0)]
        public EInfoPacketType Type { get; set; } = EInfoPacketType.FairyBead;

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
        public bool IsFull { get; set; }

        [PacketIndex(3, IsOptional = true)]
        public short? HoldingVNum { get; set; }

        [PacketIndex(4, IsOptional = true)]
        public short? ElementRate { get; set; }

        // The held fairy's own Unknown4, Unknown5 and options.
        [PacketIndex(5, IsOptional = true)]
        public byte? Unknown { get; set; }

        [PacketIndex(6, IsOptional = true)]
        public byte? Unknown2 { get; set; }

        [PacketIndex(7, IsOptional = true)]
        public byte? OptionCount { get; set; }

        [PacketListIndex(8, IsOptional = true)]
        public List<EInfoFairyOptionSubPacket>? Options { get; set; }
    }
}
