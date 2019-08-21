using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.CharacterSelectionScreen
{
    [PacketHeader("scene")]
    public class ScenePacket : PacketBase
    {
        [PacketIndex(0)]
        public byte SceneId { get; set; }
    }
}