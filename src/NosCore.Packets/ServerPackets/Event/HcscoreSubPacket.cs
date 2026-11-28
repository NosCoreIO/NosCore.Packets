//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Event
{
    [PacketHeader("hcscore_sub_packet", Scope.InGame)]
    public class HcscoreSubPacket : PacketBase
    {
        // As in rdlst: -1 when the player is neither transformed nor riding.
        [PacketIndex(0)]
        public short Morph { get; set; }

        [PacketIndex(1)]
        public CharacterClassType Class { get; set; }

        [PacketIndex(2)]
        public string? Name { get; set; }

        [PacketIndex(3)]
        public GenderType Gender { get; set; }

        // The sum over the player's hits on the boss of each hit's damage divided by ten, rounded down.
        [PacketIndex(4)]
        public int Score { get; set; }

        // The player's damage on the boss as a share of its maximum HP, rounded down.
        [PacketIndex(5)]
        public byte DamagePercent { get; set; }
    }
}
