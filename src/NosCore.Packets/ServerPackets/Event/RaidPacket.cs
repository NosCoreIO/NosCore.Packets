//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Event
{
    // Raid membership / lifecycle broadcast. OpenNos multiplexes several subtypes:
    //   raid 0 {characterId}  — member joined
    //   raid 1 {active}       — raid started (1) or ended (0)
    //   raid 2 {characterId}  — member left (-1 = full disband)
    // Value carries the subtype-specific payload.
    [PacketHeader("raid", Scope.InGame)]
    public class RaidPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1)]
        public long Value { get; set; }
    }
}
