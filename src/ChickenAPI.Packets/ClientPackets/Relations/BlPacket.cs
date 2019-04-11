using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Relations
{
    [PacketHeader("$bl")]
    public class BlPacket : PacketBase
    {
        [PacketIndex(0)]
        public string CharacterName { get; set; }
    }
}