using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.UI
{
    [PacketHeader("msg")]
    public class MsgPacket : PacketBase
    {
        [PacketIndex(0)]
        public MessageType Type { get; set; }

        [PacketIndex(1)]
        public string Message { get; set; }
    }
}