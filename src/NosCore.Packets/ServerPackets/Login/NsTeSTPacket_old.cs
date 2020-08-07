//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Login
{
    [PacketHeader("NsTeST")]
    public class NsTestPacket_old : PacketBase
    {

        [PacketIndex(0)]
        public string? AccountName { get; set; }

        [PacketIndex(1)]
        public int SessionId { get; set; }

        [PacketListIndex(2)]
        public List<NsTeStSubPacket?>? SubPacket { get; set; }
    }
}