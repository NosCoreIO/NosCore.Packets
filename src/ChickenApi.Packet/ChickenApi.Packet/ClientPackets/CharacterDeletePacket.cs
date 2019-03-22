using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("Char_DEL", AnonymousAccess = true)]
    public class CharacterDeletePacket : IPacket
    {
        [PacketIndex(0)]
        public byte Slot { get; set; }

        [PacketIndex(1)]
        public string Password { get; set; }
    }
}