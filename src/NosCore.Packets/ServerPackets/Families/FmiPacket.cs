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
    // Progress of the family's missions and achievements. The client lists every family quest
    // from quest.dat itself and only updates the ones named here.
    [PacketHeader("fmi", Scope.InGame)]
    public class FmiPacket : PacketBase
    {
        [PacketListIndex(0)]
        public List<FmiSubPacket?>? Entries { get; set; }
    }
}
