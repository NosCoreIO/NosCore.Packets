//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Miniland
{
    [PacketHeader("mlo_pmg", Scope.InGame)]
    public class MloPmgPacket : PacketBase
    {
        [PacketIndex(0)]
        public short MinigameVNum { get; set; }

        [PacketIndex(1)]
        public long MinilandPoint { get; set; }

        [PacketIndex(2)]
        public bool LowDurability { get; set; }

        [PacketIndex(3)]
        public bool IsFull { get; set; }

        [PacketIndex(4)]
        public MloPmgSubPacket?[]? MloPmgSubPackets { get; set; }
    }
}