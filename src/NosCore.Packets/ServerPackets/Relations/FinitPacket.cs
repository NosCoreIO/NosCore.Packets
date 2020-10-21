//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Relations
{
    [PacketHeader("finit", Scope.InGame)]
    public class FinitPacket : PacketBase
    {
        [PacketListIndex(0, SpecialSeparator = "|")]
        public List<FinitSubPacket?>? SubPackets { get; set; }
    }
}