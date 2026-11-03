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
    // Answers pdtse 1 with what one recipe yields and the materials it consumes.
    [PacketHeader("m_list", Scope.InGame, AllowDuplicateHeader = true)]
    public class MlistMaterialsPacket : PacketBase
    {
        [PacketIndex(0)]
        public MlistType Type { get; set; } = MlistType.Materials;

        [PacketIndex(1)]
        public short Amount { get; set; }

        [PacketListIndex(2, ListSeparator = " ", SpecialSeparator = " ")]
        public List<MlistMaterialSubPacket> Materials { get; set; } = new();

        [PacketIndex(3)]
        public short EndOfList { get; set; } = -1;
    }
}
