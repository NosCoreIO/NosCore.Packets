using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Mates
{
    [PacketHeader("petski", Scope.InGame)]
    public class PetskiPacket : PacketBase
    {
        // The pet's skill bar has three slots; -1 leaves one empty, and three of them hide the bar.
        [PacketIndex(0)]
        public short FirstSkillVNum { get; set; }

        [PacketIndex(1)]
        public short SecondSkillVNum { get; set; }

        [PacketIndex(2)]
        public short ThirdSkillVNum { get; set; }
    }
}
