using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ClientPackets.UI
{
    [PacketHeader("guri")]
    public class GuriPacket : PacketBase
    {
        [PacketIndex(0)]
        public GuriPacketType Type { get; set; }

        [PacketIndex(1)]
        public int? Argument { get; set; }

        [PacketIndex(2, IsOptional = true)]
        public long? VisualId { get; set; }

        [PacketIndex(3, IsOptional = true)]
        public long? Data { get; set; }

        [PacketIndex(4, IsOptional = true)]
        public string Value { get; set; }
    }
}