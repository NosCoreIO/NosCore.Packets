//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Miniland
{
    [PacketHeader("mlinfo", Scope.InGame)]
    public class MlinfoPacket : PacketBase
    {
        [PacketIndex(0)]
        public short WelcomeMusicInfo { get; set; } = 3800;

        [PacketIndex(1)]
        public long MinilandPoint { get; set; }

        [PacketIndex(2)]
        public byte Unknown2 { get; set; }

        [PacketIndex(3)]
        public int DailyVisitCount { get; set; }

        [PacketIndex(4)]
        public int VisitCount { get; set; }

        [PacketIndex(5)]
        public byte Unknown3 { get; set; }

        [PacketIndex(6)]
        public MinilandState MinilandState { get; set; }

        [PacketIndex(7)] 
        public short WelcomeMusicInfo2 { get; set; } = 3800;

        [PacketIndex(8)] 
        public string MinilandWelcomeMessage { get; set; } = ((short)Game18NConstString.Welcome).ToString();
    }
}