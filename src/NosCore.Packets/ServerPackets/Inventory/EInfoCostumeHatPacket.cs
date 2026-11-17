//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Inventory
{
    // Answer to eqinfo for a costume hat, a weapon skin or a wing skin.
    [PacketHeader("e_info", Scope.InGame, AllowDuplicateHeader = true)]
    public class EInfoCostumeHatPacket : PacketBase
    {
        [PacketIndex(0)]
        public EInfoPacketType Type { get; set; } = EInfoPacketType.Hat;

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
        public short CloseDefence { get; set; }

        [PacketIndex(4)]
        public short DistanceDefence { get; set; }

        [PacketIndex(5)]
        public short MagicDefence { get; set; }

        [PacketIndex(6)]
        public short DefenceDodge { get; set; }

        [PacketIndex(7)]
        public short FireResistance { get; set; }

        [PacketIndex(8)]
        public short WaterResistance { get; set; }

        [PacketIndex(9)]
        public short LightResistance { get; set; }

        [PacketIndex(10)]
        public short DarkResistance { get; set; }

        [PacketIndex(11)]
        public long Price { get; set; }

        [PacketIndex(12)]
        public short ShellEffectValue { get; set; } = -1;

        [PacketIndex(13)]
        public TradeRestriction TradeRestriction { get; set; }

        // -1 when the item never expires.
        [PacketIndex(14)]
        public int RemainingHours { get; set; }

        [PacketIndex(15)]
        public byte Unknown { get; set; }
    }
}
