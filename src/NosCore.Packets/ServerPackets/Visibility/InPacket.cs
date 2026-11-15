//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Visibility
{
    [PacketHeader("in", Scope.InGame)]
    public class InPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1, IsOptional = true)]
        [PacketPresentWhen(nameof(VisualType), VisualType.Player)]
        public string? Name { get; set; }

        [PacketIndex(2)]
        public string? VNum { get; set; }

        [PacketIndex(3)]
        public long VisualId { get; set; }

        [PacketIndex(4)]
        public short PositionX { get; set; }

        [PacketIndex(5)]
        public short PositionY { get; set; }

        [PacketIndex(6, IsOptional = true)]
        [PacketPresentWhen(nameof(VisualType), VisualType.Player, VisualType.Npc, VisualType.Monster)]
        public byte? Direction { get; set; }

        [PacketIndex(7, IsOptional = true)]
        [PacketPresentWhen(nameof(VisualType), VisualType.Player)]
        public InCharacterSubPacket? InCharacterSubPacket { get; set; }

        [PacketIndex(8, IsOptional = true)]
        [PacketPresentWhen(nameof(VisualType), VisualType.Object)]
        public InItemSubPacket? InItemSubPacket { get; set; }

        [PacketIndex(9, IsOptional = true)]
        [PacketPresentWhen(nameof(VisualType), VisualType.Npc, VisualType.Monster)]
        public InNonPlayerSubPacket? InNonPlayerSubPacket { get; set; }
    }
}