using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.CharacterSelectionScreen
{
    [PacketHeader("flinit", Scope.InGame)]
    public class FlinitPacket : PacketBase
    {
        [PacketListIndex(0, SpecialSeparator = "|")]
        public List<FlinitSubPacket?>? SubPackets { get; set; }
    }
}
