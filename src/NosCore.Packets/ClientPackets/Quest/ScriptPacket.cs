//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Quest
{
    [PacketHeader("script", Scope.InGame)]
    public class ScriptClientPacket : PacketBase
    {
        [PacketIndex(0)]
        public QuestActionType Type { get; set; }

        [PacketIndex(1, IsOptional = true)]
        public short? FirstArgument { get; set; }

        [PacketIndex(2, IsOptional = true)]
        public int? SecondArgument { get; set; }

        [PacketIndex(3, IsOptional = true)]
        public int? ThirdArgument { get; set; }
    }
}