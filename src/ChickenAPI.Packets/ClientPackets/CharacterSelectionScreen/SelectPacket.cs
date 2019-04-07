using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.CharacterSelectionScreen
{
    [PacketHeader("select", AnonymousAccess = true)]
    public class SelectPacket : IPacket
    {
        [PacketIndex(0)]
        public byte Slot { get; set; }
    }
}