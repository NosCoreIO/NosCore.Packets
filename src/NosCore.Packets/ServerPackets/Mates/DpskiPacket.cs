using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Mates
{
    [PacketHeader("dpski", Scope.InGame)]
    public class DpskiPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte State { get; set; }
    }
}
