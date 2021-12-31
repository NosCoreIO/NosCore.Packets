//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Inventory
{
    [PacketHeader("pdti", Scope.InGame)]
    public class PdtiPacket : PacketBase
    {
        [PacketIndex(0)]
        public PdtiPacketType Type { get; set; }

        [PacketIndex(1)]
        public long Vnum { get; set; }

        [PacketIndex(2)]
        public short RecipeAmount { get; set; }

        [PacketIndex(3)]
        public short Slot { get; set; }

        [PacketIndex(4)]
        public short ItemUpgrade { get; set; }

        [PacketIndex(5)]
        public short Rare { get; set; }
    }
}