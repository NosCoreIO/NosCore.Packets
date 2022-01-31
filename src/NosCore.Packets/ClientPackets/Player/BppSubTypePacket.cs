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

        [PacketIndex(1)]
        public short FreeItemVNum { get; set; }

        [PacketIndex(2)]
        public short FreeItemAmount { get; set; }

        [PacketIndex(3)]
        public short PremiumItemVNum { get; set; }

        [PacketIndex(4)]
        public short PremiumItemAmount { get; set; }

        [PacketIndex(5)]
        public bool CanGetFreeItem { get; set; }

        [PacketIndex(6)]
        public bool CanGetPremiumItem { get; set; }

        [PacketIndex(7)]
        public bool IsSuperReward { get; set; }
    }
}
