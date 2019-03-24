using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets
{
    [PacketHeader(";")]
    public class GroupTalkPacket : IPacket
    {
        [PacketIndex(0)]
        public string Message { get; set; }
    }
}