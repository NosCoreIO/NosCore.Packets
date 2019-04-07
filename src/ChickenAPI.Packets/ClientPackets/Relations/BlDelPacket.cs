using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Relations
{
    [PacketHeader("bldel")]
    public class BlDelPacket : IPacket
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }
    }
}