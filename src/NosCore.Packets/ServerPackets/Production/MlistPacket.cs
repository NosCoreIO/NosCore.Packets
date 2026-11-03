//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------
using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Production
{
    // The items a production window can make, sent just before it opens.
    [PacketHeader("m_list", Scope.InGame, AllowDuplicateHeader = true)]
    public class MlistPacket : PacketBase
    {
        [PacketIndex(0)]
        public MlistType Type { get; set; } = MlistType.Recipes;

        [PacketListIndex(1, ListSeparator = " ")]
        public List<short> ItemVNums { get; set; } = new();

        [PacketIndex(2)]
        public short EndOfList { get; set; } = -100;
    }
}
