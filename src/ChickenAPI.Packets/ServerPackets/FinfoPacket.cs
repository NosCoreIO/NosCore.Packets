using System.Collections.Generic;
using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("finfo")]
    public class FinfoPacket : IPacket
    {
        [PacketIndex(0)]
        public List<FinfoSubPackets> FriendList { get; set; }
    }
}