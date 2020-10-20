//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Inventory
{
    public class UpgradeRareSubPacket : PacketBase
    {
        [PacketIndex(0, IsOptional = true)]
        public byte? Upgrade { get; set; }

        [PacketIndex(1)]
        public sbyte Rare { get; set; }
    }
}
