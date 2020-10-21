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

namespace NosCore.Packets.ServerPackets.Entities
{
    [PacketHeader("st", Scope.InGame)]
    public class StPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType Type { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public byte Level { get; set; }

        [PacketIndex(3)]
        public byte HeroLvl { get; set; }

        [PacketIndex(4)]
        public int HpPercentage { get; set; }

        [PacketIndex(5)]
        public int MpPercentage { get; set; }

        [PacketIndex(6)]
        public int CurrentHp { get; set; }

        [PacketIndex(7)]
        public int CurrentMp { get; set; }

        [PacketListIndex(8, ListSeparator = " ", IsOptional = true)]
        public List<short>? BuffIds { get; set; }
    }
}