using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.CharacterSelectionScreen
{
    [PacketHeader("clist_start")]
    public class ClistStartPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }
    }
}