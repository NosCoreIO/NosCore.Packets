using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets
{
    [PacketHeader("n_run")]
    public class NrunPacket : IPacket
    {
        [PacketIndex(0)]
        public NrunRunnerType Runner { get; set; }

        [PacketIndex(1)]
        public short Type { get; set; }

        [PacketIndex(2)]
        public VisualType VisualType { get; set; }

        [PacketIndex(3)]
        public long VisualId { get; set; }
    }
}