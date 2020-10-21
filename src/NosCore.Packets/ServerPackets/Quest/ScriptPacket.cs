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
    [PacketHeader("script", Scope.InGame)]
    public class ScriptPacket : PacketBase
    {
        [PacketIndex(0)]
        public int ScriptId { get; set; }

        [PacketIndex(1)]
        public int ScriptStepId { get; set; }
    }
}