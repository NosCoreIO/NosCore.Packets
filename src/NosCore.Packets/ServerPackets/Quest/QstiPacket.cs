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

    [PacketHeader("qsti", Scope.InGame | Scope.InExchange)]
    public class QstiPacket : PacketBase
    {
        [PacketIndex(0, SpecialSeparator = ".")]
        public QuestSubPacket QuestSubPacket { get; set; } = null!;
    }
}