//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using System.Collections.Generic;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Miniland
{
    [PacketHeader("mlobjlst", Scope.InGame)]
    public class MlobjlstPacket : PacketBase
    {
        [PacketListIndex(0, SpecialSeparator = ".")]
        public List<MlobjlstSubPacket?>? MlobjlstSubPacket { get; set; }
    }
}