using System.Collections.Generic;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("finfo")]
    public class FinfoPacket : IPacket
    {
        [PacketIndex(0)]
        public List<FinfoSubPackets> FriendList { get; set; }
    }
}