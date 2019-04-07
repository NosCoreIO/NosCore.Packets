using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Mates
{
    [PacketHeader("suctl")]
    public class SuCtlPacket : IPacket
    {
        [PacketIndex(0)]
        public int CastId { get; set; }

        [PacketIndex(1)]
        public int Unknown2 { get; set; }

        [PacketIndex(2)]
        public long MateTransportId { get; set; }

        [PacketIndex(3)]
        public VisualType TargetType { get; set; }

        [PacketIndex(4)]
        public long TargetId { get; set; }
    }
}