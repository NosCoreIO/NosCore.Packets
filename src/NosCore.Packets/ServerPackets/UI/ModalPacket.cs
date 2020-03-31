using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.UI
{
    [PacketHeader("modal")]
    public class ModalPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; } //TODO: find modal types

        [PacketIndex(1)]
        public string? Message { get; set; }
    }
}