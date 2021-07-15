//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Bazaar
{
    [PacketHeader("c_blist", Scope.InGame | Scope.InTrade)]
    public class CBListPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? ExtraSpace { get; set; } = string.Empty;

        [PacketIndex(1)]
        public int Index { get; set; }

        [PacketIndex(2)]
        public BazaarListType TypeFilter { get; set; }

        [PacketIndex(3)]
        public byte SubTypeFilter { get; set; }

        [PacketIndex(4)]
        public byte LevelFilter { get; set; }

        [PacketIndex(5)]
        public byte RareFilter { get; set; }

        [PacketIndex(6)]
        public byte UpgradeFilter { get; set; }

        [PacketIndex(7)]
        public byte OrderFilter { get; set; }

        [PacketIndex(8)]
        public byte Unknown1 { get; set; }

        [PacketIndex(9)]
        public byte Unknown2 { get; set; }

        [PacketListIndex(10)]
        public List<short>? ItemVNumFilter { get; set; }
    }
}