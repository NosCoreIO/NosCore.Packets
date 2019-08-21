using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.UI
{
    [PacketHeader("modal")]
    public class ModalPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; } //TODO: find modal types

        [PacketIndex(1)]
        public string Message { get; set; }
    }
}