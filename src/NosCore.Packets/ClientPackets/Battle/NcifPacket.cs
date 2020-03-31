using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Battle
{
    [PacketHeader("ncif")]
    public class NcifPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType Type { get; set; }

        [PacketIndex(1)]
        [Range(0, long.MaxValue)]
        public long TargetId { get; set; }
    }
}