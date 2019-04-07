using System.ComponentModel.DataAnnotations;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Movement
{
    [PacketHeader("dir")]
    public class ClientDirPacket : IPacket
    {
        [PacketIndex(0)]
        [Range(0, 7)]
        public byte Direction { get; set; }

        [PacketIndex(1)]
        public VisualType VisualType { get; set; }

        [PacketIndex(2)]
        public long VisualId { get; set; }
    }
}