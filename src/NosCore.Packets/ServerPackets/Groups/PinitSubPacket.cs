//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Groups
{
    [PacketHeader("pinit_sub_packet", Scope.InGame)]
    public class PinitSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        [Range(0, long.MaxValue)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public int GroupPosition { get; set; }

        [PacketIndex(3)]
        public byte Level { get; set; }

        [PacketIndex(4)]
        public string? Name { get; set; }

        [PacketIndex(5)]
        public int Unknown { get; set; } //TODO: Find what this is made for

        [PacketIndex(6)]
        public GenderType Gender { get; set; }

        [PacketIndex(7)]
        public short Race { get; set; }

        [PacketIndex(8)]
        public short Morph { get; set; }

        [PacketIndex(9)]
        public byte HeroLevel { get; set; }
    }
}