using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Relations
{
    [PacketHeader("$bl")]
    public class BlPacket : PacketBase
    {
        [PacketIndex(0)]
        public string CharacterName { get; set; }
    }
}