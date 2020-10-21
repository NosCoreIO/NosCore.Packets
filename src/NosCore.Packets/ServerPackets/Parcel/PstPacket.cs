//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Parcel
{
    [PacketHeader("pst", Scope.InGame)]
    public class PstPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType Type { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public int GroupOrder { get; set; }

        [PacketIndex(3)]
        public int HpLeft { get; set; }

        [PacketIndex(4)]
        public int MpLeft { get; set; }

        [PacketIndex(5)]
        public int HpLoad { get; set; }

        [PacketIndex(6)]
        public int MpLoad { get; set; }

        [PacketIndex(7)]
        public short Race { get; set; }

        [PacketIndex(8)]
        public GenderType Gender { get; set; }

        [PacketIndex(9)]
        public short Morph { get; set; }

        [PacketListIndex(10, IsOptional = true)]
        public List<int>? BuffIds { get; set; }
    }
}