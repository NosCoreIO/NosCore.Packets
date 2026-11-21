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
    // Answer to eqinfo for a fairy.
    [PacketHeader("e_info", Scope.InGame, AllowDuplicateHeader = true)]
    public class EInfoFairyPacket : PacketBase
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
        public ElementType Element { get; set; }

        [PacketIndex(3)]
        public short ElementRate { get; set; }

        [PacketIndex(4)]
        public int Unknown { get; set; }

        // With ExperienceLeft, the same total for every fairy at one rate (19 350 at 80).
        [PacketIndex(5)]
        public long Experience { get; set; }

        [PacketIndex(6)]
        public long Price { get; set; }

        [PacketIndex(7)]
        public byte Unknown2 { get; set; }

        [PacketIndex(8)]
        public byte Unknown3 { get; set; }

        [PacketIndex(9)]
        public long ExperienceLeft { get; set; }

        [PacketIndex(10)]
        public long BoundCharacterId { get; set; }

        [PacketIndex(11)]
        public byte Unknown4 { get; set; }

        [PacketIndex(12)]
        public byte Unknown5 { get; set; }

        // The line of a fairy without options is one field shorter, all of its last fields 0, so which field it
        // leaves out is not settled.
        [PacketIndex(13, IsOptional = true)]
        public byte? OptionCount { get; set; }

        [PacketListIndex(14, IsOptional = true)]
        public List<EInfoFairyOptionSubPacket>? Options { get; set; }
    }
}
