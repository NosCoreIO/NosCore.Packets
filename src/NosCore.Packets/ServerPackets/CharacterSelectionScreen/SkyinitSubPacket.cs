using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.CharacterSelectionScreen
{
    public class SkyinitSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }

        [PacketIndex(1)]
        public byte Level { get; set; }

        [PacketIndex(2)]
        public byte HeroLevel { get; set; }

        [PacketIndex(3)]
        public int Points { get; set; }

        [PacketIndex(4)]
        public string? CharacterName { get; set; }
    }
}
