using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Player
{
    [PacketHeader("stbm", Scope.InGame)]
    public class StbmPacket : PacketBase
    {
        // One value on some lines, 17 or 40 on others.
        [PacketListIndex(0, ListSeparator = " ")]
        public List<short> Values { get; set; } = [];
    }
}