//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Inventory
{
    public class EInfoShellOptionSubPacket : PacketBase
    {
        private const byte ArmorLevelOffset = 12;

        // The option level, 1 to 12, for a weapon and an armour alike.
        public byte Level { get; set; }

        public bool IsArmor { get; set; }

        // The client numbers an armour's option levels 13 to 24; it ranks and colours level n + 12 like level n.
        [PacketIndex(0)]
        public byte WireLevel
        {
            get => IsArmor ? (byte)(Level + ArmorLevelOffset) : Level;
            set
            {
                IsArmor = value > ArmorLevelOffset;
                Level = IsArmor ? (byte)(value - ArmorLevelOffset) : value;
            }
        }

        [PacketIndex(1)]
        public byte Type { get; set; }

        [PacketIndex(2)]
        public int Value { get; set; }

        // From -2 to 2, mostly 0.
        [PacketIndex(3)]
        public short Unknown { get; set; }
    }
}
