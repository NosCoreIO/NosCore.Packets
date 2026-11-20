//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Player
{
    [PacketHeader("c_mode", Scope.InGame)]
    public class CModePacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public int Morph { get; set; }

        [PacketIndex(3)]
        public byte MorphUpgrade { get; set; }

        [PacketIndex(4)]
        public short MorphDesign { get; set; }

        // Only a player's line carries the last three fields.
        [PacketIndex(5, IsOptional = true)]
        [PacketPresentWhen(nameof(VisualType), VisualType.Player)]
        public byte? MorphBonus { get; set; }

        [PacketIndex(6, IsOptional = true)]
        [PacketPresentWhen(nameof(VisualType), VisualType.Player)]
        public byte? Size { get; set; }

        [PacketIndex(7, IsOptional = true)]
        [PacketPresentWhen(nameof(VisualType), VisualType.Player)]
        public short? MorphSkin { get; set; }
    }
}