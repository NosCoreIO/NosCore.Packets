using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Instance
{
    [PacketHeader("rstart", Scope.InGame)]
    public class RStartPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte? Type { get; set; }
    }
}
