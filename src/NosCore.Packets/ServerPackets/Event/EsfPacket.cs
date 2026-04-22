using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Event
{
    [PacketHeader("esf", Scope.InGame)]
    public class EsfPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Value { get; set; }
    }
}
