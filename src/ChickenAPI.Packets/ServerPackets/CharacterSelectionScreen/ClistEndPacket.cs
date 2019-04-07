using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.CharacterSelectionScreen
{
    [PacketHeader("clist_end")]
    public class ClistEndPacket : IPacket
    {
    }
}