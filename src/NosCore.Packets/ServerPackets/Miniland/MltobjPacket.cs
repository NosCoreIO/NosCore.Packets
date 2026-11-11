//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using System.Collections.Generic;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Miniland
{
    [PacketHeader("mltobj", Scope.InGame)]
    public class MltobjPacket : PacketBase
    {
        [PacketListIndex(0, SpecialSeparator = ".")]
        public List<MltobjSubPacket?>? MltobjSubPacket { get; set; }
    }
}
