using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Battle
{
    [PacketHeader("rank_cool", Scope.InGame)]
    public class RankCoolPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Unknown1 { get; set; } //TODO to find

        [PacketIndex(1)]
        public byte Unknown2 { get; set; } //TODO to find

        [PacketIndex(2)]
        public int Cooldown { get; set; }
    }
}
