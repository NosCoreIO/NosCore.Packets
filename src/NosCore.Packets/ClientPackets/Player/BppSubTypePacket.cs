//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Player
{
    public class BppSubTypePacket : PacketBase
    {
        [PacketIndex(0)]
        public short BearingId { get; set; }

        [PacketIndex(1, SpecialSeparator = " ")]
        public short FreeItemVNum { get; set; }

        [PacketIndex(2, SpecialSeparator = " ")]
        public short FreeItemAmount { get; set; }

        [PacketIndex(3, SpecialSeparator = " ")]
        public short PremiumItemVNum { get; set; }

        [PacketIndex(4, SpecialSeparator = " ")]
        public short PremiumItemAmount { get; set; }

        [PacketIndex(5, SpecialSeparator = " ")]
        public bool CanGetFreeItem { get; set; }

        [PacketIndex(6, SpecialSeparator = " ")]
        public bool CanGetPremiumItem { get; set; }

        [PacketIndex(7, SpecialSeparator = " ")]
        public bool IsSuperReward { get; set; }
    }
}
