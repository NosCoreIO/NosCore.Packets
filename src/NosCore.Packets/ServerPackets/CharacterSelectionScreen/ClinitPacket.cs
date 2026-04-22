using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.CharacterSelectionScreen
{
    [PacketHeader("clinit", Scope.InGame)]
    public class ClinitPacket : PacketBase
    {
        [PacketListIndex(0, SpecialSeparator = "|")]
        public List<ClinitSubPacket?>? SubPackets { get; set; }
    }
}
