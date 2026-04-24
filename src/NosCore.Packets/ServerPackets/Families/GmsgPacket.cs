//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Families
{
    [PacketHeader("gmsg", Scope.InGame)]
    public class GmsgPacket : PacketBase
    {
        [PacketListIndex(0)]
        public List<GmsgSubPacket?>? Entries { get; set; }
    }
}
