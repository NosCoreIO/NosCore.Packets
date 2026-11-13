//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.TimeSpaces
{
    [PacketHeader("minfo", Scope.InGame)]
    public class MinfoPacket : PacketBase
    {
        [PacketIndex(0)]
        public bool KillAllMonsters { get; set; }

        [PacketIndex(1)]
        public bool GoToExit { get; set; }

        [PacketIndex(2, SpecialSeparator = ".")]
        public MinfoObjectiveSubPacket? KillMonster { get; set; } = MinfoObjectiveSubPacket.None;

        [PacketIndex(3, SpecialSeparator = ".")]
        public MinfoObjectiveSubPacket? CollectItem { get; set; } = MinfoObjectiveSubPacket.None;

        [PacketIndex(4)]
        public MinfoConversationSubPacket? Conversation { get; set; } = MinfoConversationSubPacket.None;

        [PacketIndex(5, SpecialSeparator = ".")]
        public MinfoObjectiveSubPacket? InteractObjects { get; set; } = MinfoObjectiveSubPacket.None;

        [PacketIndex(6)]
        public bool ProtectNpc { get; set; }

        [PacketIndex(7)]
        public int MaxLives { get; set; }

        [PacketIndex(8)]
        public int Unknown { get; set; }
    }
}
