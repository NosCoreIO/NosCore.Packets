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
    [PacketHeader("target", Scope.InGame)]
    public class TargetPacket : PacketBase
    {
        [PacketIndex(0)]
        public short TargetX { get; set; }

        [PacketIndex(1)]
        public short TargetY { get; set; }

        [PacketIndex(2)]
        public short TargetMap { get; set; }

        [PacketIndex(3)]
        public short QuestId { get; set; }
    }
}