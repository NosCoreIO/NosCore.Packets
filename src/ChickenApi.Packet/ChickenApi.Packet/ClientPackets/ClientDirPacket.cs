using System.ComponentModel.DataAnnotations;
using ChickenApi.Packet.Enumerations;

namespace ChickenApi.Packet.ClientPackets
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