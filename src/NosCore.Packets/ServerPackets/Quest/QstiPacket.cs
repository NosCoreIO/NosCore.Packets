//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Quest
{

    [PacketHeader("qsti")]
    public class QstiPacket : PacketBase
    {
        [PacketIndex(0, SpecialSeparator = ".")]
        public QuestSubPacket QuestSubPacket { get; set; } = null!;
    }
}