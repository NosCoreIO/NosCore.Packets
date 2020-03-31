using System.Collections.Generic;
using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Relations
{
    [PacketHeader("finfo")]
    public class FinfoPacket : PacketBase
    {
        [PacketIndex(0)]
        public List<FinfoSubPackets?>? FriendList { get; set; }
    }
}