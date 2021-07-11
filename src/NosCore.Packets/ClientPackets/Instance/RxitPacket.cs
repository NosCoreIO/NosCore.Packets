using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Instance
{
    [PacketHeader("rxit", Scope.InGame)]
    public class RxitPacket : PacketBase
    {
        [PacketIndex(0)]
        public RxitPacketType State { get; set; }
    }
}
