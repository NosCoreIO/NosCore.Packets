//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Entities
{
    // Slides an entity to a cell, as a knock-back, a pull or a charge does, where tp snaps it there.
    [PacketHeader("guri", Scope.InGame, AllowDuplicateHeader = true)]
    public class GuriForcedMovePacket : PacketBase
    {
        [PacketIndex(0)]
        public GuriPacketType Type { get; set; } = GuriPacketType.ForcedMove;

        [PacketIndex(1)]
        public VisualType VisualType { get; set; }

        [PacketIndex(2)]
        public long VisualId { get; set; }

        [PacketIndex(3)]
        public short X { get; set; }

        [PacketIndex(4)]
        public short Y { get; set; }

        [PacketIndex(5)]
        public byte Unknown5 { get; set; } = 3;

        // 2 on a knock-back or a charge, 4 or 8 on a pull.
        [PacketIndex(6)]
        public byte Unknown6 { get; set; } = 2;

        [PacketIndex(7)]
        public byte Unknown7 { get; set; } = 2;

        // Absent on a knock-back or a pull, 11 on a monster's charge.
        [PacketIndex(8)]
        public short? Unknown8 { get; set; }

        // 1 when a player moves, 0 when a monster does.
        [PacketIndex(9)]
        public byte Unknown9 { get; set; }
    }
}
