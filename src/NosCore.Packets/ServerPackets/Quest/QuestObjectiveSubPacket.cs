//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Quest
{
    public class QuestObjectiveSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public short CurrentCount { get; set; }

        [PacketIndex(1)]
        public short MaxCount { get; set; }

        [PacketIndex(2, IsOptional = true)]
        public bool? IsFinished { get; set; }
    }
}