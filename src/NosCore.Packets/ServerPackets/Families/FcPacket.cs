//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Families
{
    // Act4 faction statistics packet. Tells the client which faction the character
    // belongs to plus the global Angel vs Demon war state (reset timer, score ratio,
    // mode). OpenNos appends more per-faction detail after the 4th field — the
    // minimum header is what clients strictly require.
    [PacketHeader("fc", Scope.InGame)]
    public class FcPacket : PacketBase
    {
        [PacketIndex(0)]
        public FactionType Faction { get; set; }

        [PacketIndex(1)]
        public int MinutesUntilReset { get; set; }

        [PacketIndex(2)]
        public int Percentage { get; set; }

        [PacketIndex(3)]
        public int Mode { get; set; }
    }
}
