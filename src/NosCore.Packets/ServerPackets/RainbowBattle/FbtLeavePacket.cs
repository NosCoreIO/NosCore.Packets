//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.RainbowBattle
{
    // Clears the Rainbow Battle window once the receiver has left the battle.
    [PacketHeader("fbt", Scope.InGame, AllowDuplicateHeader = true)]
    public class FbtLeavePacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; } = 2;

        [PacketIndex(1)]
        public int Value { get; set; } = -1;
    }
}
