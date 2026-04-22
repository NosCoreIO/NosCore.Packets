using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.CharacterSelectionScreen
{
    [PacketHeader("kdlinit", Scope.InGame)]
    public class KdlinitPacket : PacketBase
    {
        [PacketListIndex(0, SpecialSeparator = "|")]
        public List<KdlinitSubPacket?>? SubPackets { get; set; }
    }
}
