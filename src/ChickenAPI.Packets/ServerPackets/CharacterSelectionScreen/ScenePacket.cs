using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.CharacterSelectionScreen
{
    [PacketHeader("scene")]
    public class ScenePacket : IPacket
    {
        [PacketIndex(0)]
        public byte SceneId { get; set; }
    }
}