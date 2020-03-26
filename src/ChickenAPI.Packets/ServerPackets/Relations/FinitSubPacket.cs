using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ServerPackets.Relations
{
    public class FinitSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }

        [PacketIndex(1)]
        public CharacterRelationType RelationType { get; set; }

        [PacketIndex(2)]
        public bool IsOnline { get; set; }

        [PacketIndex(3)]
        public string? CharacterName { get; set; }
    }
}