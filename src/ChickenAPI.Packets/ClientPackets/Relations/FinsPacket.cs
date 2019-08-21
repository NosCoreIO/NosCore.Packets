using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ClientPackets.Relations
{
    [PacketHeader("fins")]
    public class FinsPacket : PacketBase
    {
        [PacketIndex(0)]
        public FinsPacketType Type { get; set; }

        [PacketIndex(1)]
        public long CharacterId { get; set; }
    }
}