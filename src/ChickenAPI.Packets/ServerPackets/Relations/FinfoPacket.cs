using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Relations
{
    [PacketHeader("finfo")]
    public class FinfoPacket : PacketBase
    {
        [PacketIndex(0)]
        public List<FinfoSubPackets?>? FriendList { get; set; }
    }
}