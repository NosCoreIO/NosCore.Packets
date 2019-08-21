using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.CharacterSelectionScreen
{
    [PacketHeader("select", AnonymousAccess = true)]
    public class SelectPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Slot { get; set; }
    }
}