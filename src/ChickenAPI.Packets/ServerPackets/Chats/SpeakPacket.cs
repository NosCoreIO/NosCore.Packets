using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Chats
{
    [PacketHeader("spk")]
    public class SpeakPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public SpeakType SpeakType { get; set; }

        [PacketIndex(3)]
        public string EntityName { get; set; }

        [PacketIndex(4)]
        public string Message { get; set; }
    }
}