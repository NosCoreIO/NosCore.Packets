using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets
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