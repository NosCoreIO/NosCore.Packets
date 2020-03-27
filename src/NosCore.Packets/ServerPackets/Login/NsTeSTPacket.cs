using System.Collections.Generic;
using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Login
{
    [PacketHeader("NsTeST")]
    public class NsTestPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? AccountName { get; set; }

        //this seems to be always 2 in case of new auth and null else
        [PacketIndex(1, IsOptional = true)]
        public int? Unknown { get; set; }

        [PacketIndex(2)]
        public int SessionId { get; set; }


        [PacketIndex(3)]
        public List<NsTeStSubPacket?>? SubPacket { get; set; }
    }
}