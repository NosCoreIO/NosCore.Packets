using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.UI
{
    [PacketHeader("ascr", Scope.InGame)]
    public class AscrPacket : PacketBase
    {
        [PacketIndex(0)]
        public int CurrentKill { get; set; }

        [PacketIndex(1)]
        public int CurrentDie { get; set; }

        [PacketIndex(2)]
        public int CurrentTc { get; set; }

        [PacketIndex(3)]
        public int ArenaKill { get; set; }

        [PacketIndex(4)]
        public int ArenaDie { get; set; }

        [PacketIndex(5)]
        public int ArenaTc { get; set; }

        [PacketIndex(6)]
        public int KillGroup { get; set; }

        [PacketIndex(7)]
        public int DieGroup { get; set; }

        [PacketIndex(8)]
        public AscrPacket? Type { get; set; }
    }
}
