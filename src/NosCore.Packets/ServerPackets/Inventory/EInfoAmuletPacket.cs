//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Inventory
{
    // Answer to eqinfo for an amulet.
    [PacketHeader("e_info", Scope.InGame, AllowDuplicateHeader = true)]
    public class EInfoAmuletPacket : PacketBase
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

        // In tenths of a second.
        [PacketIndex(3)]
        public long RemainingTime { get; set; }

        [PacketIndex(4)]
        public byte Unknown { get; set; }

        [PacketIndex(5)]
        public byte Unknown2 { get; set; }

        [PacketIndex(6)]
        public long Price { get; set; }
    }
}
