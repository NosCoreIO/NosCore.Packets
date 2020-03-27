using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Movement
{
    [PacketHeader("dir")]
    public class ClientDirPacket : PacketBase
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