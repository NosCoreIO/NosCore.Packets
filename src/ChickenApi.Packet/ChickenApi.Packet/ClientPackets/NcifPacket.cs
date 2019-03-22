using System.ComponentModel.DataAnnotations;
using ChickenApi.Packet.Enumerations;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("ncif")]
    public class NcifPacket : IPacket
    {
        [PacketIndex(0)]
        public VisualType Type { get; set; }

        [PacketIndex(1)]
        [Range(0, long.MaxValue)]
        public long TargetId { get; set; }
    }
}