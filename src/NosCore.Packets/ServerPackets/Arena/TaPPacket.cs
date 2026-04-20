//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Arena
{
    // Team arena participant roster: ta_p {arenaType} {teamType} {slots1} {slots2}
    // {serializedGroups}. Groups carries a pre-rendered list of (char sub-packets)
    // joined by spaces — OpenNos keeps that opaque so the server can ship whatever
    // shape the UI expects without re-encoding.
    [PacketHeader("ta_p", Scope.InGame)]
    public class TaPPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte ArenaType { get; set; }

        [PacketIndex(1)]
        public byte TeamType { get; set; }

        [PacketIndex(2)]
        public int SlotsTeam1 { get; set; }

        [PacketIndex(3)]
        public int SlotsTeam2 { get; set; }

        [PacketIndex(4)]
        public string? Groups { get; set; }
    }
}
