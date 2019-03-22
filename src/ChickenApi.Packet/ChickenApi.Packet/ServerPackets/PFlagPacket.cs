using ChickenApi.Packet.Enumerations;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("pflag")]
    public class PflagPacket : IPacket
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public long Flag { get; set; }
    }
}