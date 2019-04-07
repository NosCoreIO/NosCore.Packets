using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Relations
{
    [PacketHeader("finfo")]
    public class FinfoPacket : IPacket
    {
        [PacketIndex(0)]
        public List<FinfoSubPackets> FriendList { get; set; }
    }
}