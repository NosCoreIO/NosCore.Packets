//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Arena
{
    // Team arena scoreboard. The scores always read Zenas first; TimeRemaining (seconds) only
    // counts with the Clock mode.
    [PacketHeader("ta_m", Scope.InGame)]
    public class TaMPacket : PacketBase
    {
        [PacketIndex(0)]
        public TaWindowMode Type { get; set; }

        [PacketIndex(1)]
        public int ZenasScore { get; set; }

        [PacketIndex(2)]
        public int EreniaScore { get; set; }

        [PacketIndex(3)]
        public int TimeRemaining { get; set; }

        [PacketIndex(4)]
        public int Unknown { get; set; }
    }
}
