using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Player
{
    [PacketHeader("stp2", Scope.InGame)]
    public class Stp2Packet : PacketBase
    {
        [PacketListIndex(0, SpecialSeparator = " ")]
        public List<StpSubPacket?>? SubPackets { get; set; }
    }
}
