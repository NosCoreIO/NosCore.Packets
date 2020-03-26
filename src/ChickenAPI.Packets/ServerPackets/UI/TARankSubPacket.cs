using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ServerPackets.UI
{
    public class TARankSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public short? Score { get; set; }

        [PacketIndex(1)]
        public byte? Level { get; set; }

        [PacketIndex(2)]
        public byte? HeroLevel { get; set; }

        [PacketIndex(3)]
        public string? Name { get; set; }

        [PacketIndex(4)]
        public CharacterClassType? CharacterClass { get; set; }

        [PacketIndex(5)]
        public GenderType? Gender { get; set; }

        [PacketIndex(6)]
        public short? Morph { get; set; }
    }
}