using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Player
{
    [PacketHeader("levelup")]
    public class LevelUpPacket : IPacket
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }
    }
}