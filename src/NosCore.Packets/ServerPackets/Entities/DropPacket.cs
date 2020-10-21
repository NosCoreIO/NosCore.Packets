//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Entities
{
    [PacketHeader("drop", Scope.InGame)]
    public class DropPacket : PacketBase
    {
        [PacketIndex(0)]
        public short VNum { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public short PositionX { get; set; }

        [PacketIndex(3)]
        public short PositionY { get; set; }

        [PacketIndex(4)]
        public short Amount { get; set; }

        [PacketIndex(5)]
        public byte Unknown { get; set; }

        [PacketIndex(6)]
        public long? OwnerId { get; set; }
    }
}