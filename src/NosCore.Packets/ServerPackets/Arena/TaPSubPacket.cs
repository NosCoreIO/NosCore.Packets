//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Arena
{
    // An empty slot leaves every field null.
    [PacketHeader("ta_p_sub_packet", Scope.InGame)]
    public class TaPSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public bool? IsAlive { get; set; }

        [PacketIndex(1)]
        public long? CharacterId { get; set; }

        [PacketIndex(2)]
        public CharacterClassType? Class { get; set; }

        [PacketIndex(3)]
        public GenderType? Gender { get; set; }

        [PacketIndex(4)]
        public short? Morph { get; set; }
    }
}
