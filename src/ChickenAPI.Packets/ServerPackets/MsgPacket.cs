using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("msg")]
    public class MsgPacket : IPacket
    {
        [PacketIndex(0)]
        public MessageType Type { get; set; }

        [PacketIndex(1)]
        public string Message { get; set; }
    }
}