using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Mates
{
    [PacketHeader("petski", Scope.InGame)]
    public class PetskiPacket : PacketBase
    {
        [PacketIndex(0)]
        public int MateTransportId { get; set; }

        [PacketIndex(1)]
        public short FirstSkillVNum { get; set; }

        [PacketIndex(2)]
        public short SecondSkillVNum { get; set; }
    }
}
