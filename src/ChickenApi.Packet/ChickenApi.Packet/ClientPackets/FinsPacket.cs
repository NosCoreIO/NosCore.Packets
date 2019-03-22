using ChickenApi.Packet.Enumerations;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("fins")]
    public class FinsPacket : IPacket
    {
        [PacketIndex(0)]
        public FinsPacketType Type { get; set; }

        [PacketIndex(1)]
        public long CharacterId { get; set; }
    }
}