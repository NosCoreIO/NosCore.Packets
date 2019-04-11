using System.ComponentModel.DataAnnotations;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Groups
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