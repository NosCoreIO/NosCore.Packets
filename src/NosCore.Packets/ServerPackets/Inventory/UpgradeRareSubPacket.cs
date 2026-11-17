//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Inventory
{
    public class UpgradeRareSubPacket : PacketBase
    {
        public byte Upgrade { get; set; }

        public sbyte Rare { get; set; }

        // The client reads one number and splits it with a truncating division by ten, so a negative
        // rare only survives on an item without upgrade: upgrade 5 with rare -2 arrives as 4 and 8.
        [PacketIndex(0)]
        public short UpgradeRare
        {
            get => (short)(Upgrade * 10 + Rare);
            set
            {
                Upgrade = (byte)(value / 10);
                Rare = (sbyte)(value % 10);
            }
        }
    }
}
