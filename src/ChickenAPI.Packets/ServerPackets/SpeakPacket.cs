using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Enumerations;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("spk")]
    public class SpeakPacket : IPacket
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