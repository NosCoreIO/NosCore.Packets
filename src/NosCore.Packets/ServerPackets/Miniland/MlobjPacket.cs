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
    [PacketHeader("mlobj", Scope.InGame)]
    public class MlobjPacket : PacketBase
    {
        [PacketIndex(0)]
        public bool InUse { get; set; }

        [PacketIndex(1)]
        public short Slot { get; set; }

        [PacketIndex(2)]
        public MlobjSubPacket? MlobjSubPacket { get; set; }
    }
}