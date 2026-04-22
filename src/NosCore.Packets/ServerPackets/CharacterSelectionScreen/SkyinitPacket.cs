using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.CharacterSelectionScreen
{
    [PacketHeader("skyinit", Scope.InGame)]
    public class SkyinitPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketListIndex(1, SpecialSeparator = "|")]
        public List<SkyinitSubPacket?>? SubPackets { get; set; }
    }
}
