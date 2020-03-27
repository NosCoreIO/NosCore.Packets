using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.CharacterSelectionScreen
{
    [PacketHeader("select", AnonymousAccess = true)]
    public class SelectPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Slot { get; set; }
    }
}