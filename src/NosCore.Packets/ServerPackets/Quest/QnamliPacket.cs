//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Quest
{
    [PacketHeader("qnamli", Scope.InGame)]
    public class QnamliPacket : PacketBase
    {
        [PacketIndex(0)]
        public int QuestId { get; set; }

        [PacketIndex(1, RemoveHash = true)]
        public string? Guri { get; set; }

        [PacketIndex(2)]
        public int TargetId { get; set; }

        [PacketIndex(3)]
        public int Value1 { get; set; }

        [PacketIndex(4)]
        public int Value2 { get; set; }

        [PacketIndex(5)]
        public int Value3 { get; set; }
    }
}
