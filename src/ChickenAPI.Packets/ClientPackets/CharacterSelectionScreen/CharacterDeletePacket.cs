using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.CharacterSelectionScreen
{
    [PacketHeader("Char_DEL", AnonymousAccess = true)]
    public class CharacterDeletePacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Slot { get; set; }

        [PacketIndex(1)]
        public string Password { get; set; }
    }
}