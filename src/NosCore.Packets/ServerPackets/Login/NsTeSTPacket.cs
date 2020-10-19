//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Login
{
    [PacketHeader("NsTeST")]
    public class NsTestPacket : PacketBase, ILoginPacket
    {
        [PacketIndex(0)]
        public RegionType RegionType { get; set; }

        [PacketIndex(1)]
        public string? AccountName { get; set; }

        //this seems to be always 2 in case of new auth and null else
        [PacketIndex(2, IsOptional = true)]
        public int? Unknown { get; set; }

        [PacketIndex(3)]
        public int SessionId { get; set; }


        [PacketListIndex(4)]
        public List<NsTeStSubPacket?>? SubPacket { get; set; }
    }
}