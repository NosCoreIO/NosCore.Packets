//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Battle
{
    // Starts the card's lasting visual effect on the entity, for every client that sees it, or ends it when
    // RemainingTime is 0. Only cards flagged for a lasting effect in Card.dat get one; the buff icon is bf's.
    [PacketHeader("bf_e", Scope.InGame)]
    public class BfePacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public short CardId { get; set; }

        // Deciseconds left on the card.
        [PacketIndex(3)]
        public short RemainingTime { get; set; }
    }
}
