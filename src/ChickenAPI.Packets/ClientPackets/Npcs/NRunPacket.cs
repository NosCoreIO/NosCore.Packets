using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Npcs
{
    [PacketHeader("n_run")]
    public class NrunPacket : PacketBase
    {
        [PacketIndex(0)]
        public NrunRunnerType Runner { get; set; }

        [PacketIndex(1, IsOptional = true)]
        public short? Type { get; set; }

        [PacketIndex(2, IsOptional = true)]
        public VisualType? VisualType { get; set; }

        [PacketIndex(3, IsOptional = true)]
        public long? VisualId { get; set; }
    }
}