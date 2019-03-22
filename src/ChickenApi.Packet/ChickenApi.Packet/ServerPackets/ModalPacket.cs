using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("modal")]
    public class ModalPacket : IPacket
    {
        [PacketIndex(0)]
        public byte Type { get; set; } //TODO: find modal types

        [PacketIndex(1)]
        public string Message { get; set; }
    }
}