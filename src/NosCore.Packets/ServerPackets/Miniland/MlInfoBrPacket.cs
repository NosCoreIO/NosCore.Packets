//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Miniland
{
    [PacketHeader("mlinfobr", Scope.InGame)]
    public class MlInfoBrPacket : PacketBase
    {
        [PacketIndex(0)]
        public short MinilandMusicId { get; set; }

        [PacketIndex(1)]
        public string? Name { get; set; }

        [PacketIndex(2)]
        public int DailyVisitCount { get; set; }

        [PacketIndex(3)]
        public int VisitCount { get; set; }

        [PacketIndex(4)]
        public byte Unknown2 { get; set; }

        [PacketIndex(5)]
        public string? MinilandMessage { get; set; }
    }
}