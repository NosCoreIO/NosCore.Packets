//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.RainbowBattle
{
    [PacketHeader("fbt", Scope.InGame, AllowDuplicateHeader = true)]
    public class FbtClockPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; } = 5;

        [PacketIndex(1)]
        public FbtClockMode Mode { get; set; }

        [PacketIndex(2)]
        public int Seconds { get; set; }
    }
}
