namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("scene")]
    public class ScenePacket : IPacket
    {
        [PacketIndex(0)]
        public byte SceneId { get; set; }
    }
}