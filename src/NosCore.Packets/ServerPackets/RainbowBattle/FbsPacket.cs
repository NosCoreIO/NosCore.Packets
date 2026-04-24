//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.RainbowBattle
{
    [PacketHeader("fbs", Scope.InGame)]
    public class FbsPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte TeamId { get; set; }

        [PacketIndex(1)]
        public int TeamCount { get; set; }

        [PacketIndex(2)]
        public int RedPoints { get; set; }

        [PacketIndex(3)]
        public int BluePoints { get; set; }

        [PacketIndex(4)]
        public int SmallFlags { get; set; }

        [PacketIndex(5)]
        public int MediumFlags { get; set; }

        [PacketIndex(6)]
        public int BigFlags { get; set; }

        [PacketIndex(7)]
        public string? TeamName { get; set; }
    }
}
