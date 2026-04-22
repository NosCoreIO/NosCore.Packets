using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Mates
{
    [PacketHeader("petski", Scope.InGame)]
    public class PetskiPacket : PacketBase
    {
        [PacketIndex(0)]
        public sbyte MateTransportId { get; set; }
    }
}
