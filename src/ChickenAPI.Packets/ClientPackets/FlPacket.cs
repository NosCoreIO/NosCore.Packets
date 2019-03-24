using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets
{
    [PacketHeader("$fl")]
    public class FlPacket : IPacket
    {
        [PacketIndex(0)]
        public string CharacterName { get; set; }
    }
}