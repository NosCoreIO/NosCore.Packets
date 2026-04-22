using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Groups
{
    [PacketHeader("ftpt", Scope.InGame)]
    public class FtptPacket : PacketBase
    {
        [PacketIndex(0)]
        public int? LeaderId { get; set; }
    }
}
