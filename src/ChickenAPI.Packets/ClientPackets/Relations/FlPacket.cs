using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Relations
{
    [PacketHeader("$fl")]
    public class FlPacket : PacketBase
    {
        [PacketIndex(0)]
        public string CharacterName { get; set; }
    }
}