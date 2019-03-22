using System.ComponentModel.DataAnnotations;
using ChickenApi.Packet.Enumerations;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("pjoin")]
    public class PjoinPacket : IPacket
    {
        [PacketIndex(0)]
        public GroupRequestType RequestType { get; set; }

        [PacketIndex(1)]
        [Range(0, long.MaxValue)]
        public long CharacterId { get; set; }
    }
}