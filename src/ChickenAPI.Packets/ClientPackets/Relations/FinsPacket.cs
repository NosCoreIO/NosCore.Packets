using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Relations
{
    [PacketHeader("fins")]
    public class FinsPacket : IPacket
    {
        [PacketIndex(0)]
        public FinsPacketType Type { get; set; }

        [PacketIndex(1)]
        public long CharacterId { get; set; }
    }
}