using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Groups
{
    [PacketHeader("pjoin")]
    public class PjoinPacket : PacketBase
    {
        [PacketIndex(0)]
        public GroupRequestType RequestType { get; set; }

        [PacketIndex(1)]
        [Range(0, long.MaxValue)]
        public long CharacterId { get; set; }
    }
}