//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Event
{
    // Raid boss fight banner. Drives the "Raid in progress / X minutes left" overlay
    // shown during instance raids. Format: raid_bf {flag} {type} {seconds}.
    [PacketHeader("raidbf", Scope.InGame)]
    public class RaidbfPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Flag { get; set; }

        [PacketIndex(1)]
        public byte Type { get; set; }

        [PacketIndex(2)]
        public int Seconds { get; set; }
    }
}
