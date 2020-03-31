using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.CharacterSelectionScreen
{
    [PacketHeader("scene")]
    public class ScenePacket : PacketBase
    {
        [PacketIndex(0)]
        public byte SceneId { get; set; }
    }
}