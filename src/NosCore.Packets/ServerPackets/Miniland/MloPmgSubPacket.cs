//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Miniland
{
    public class MloPmgSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public short BoxVNum { get; set; }

        [PacketIndex(1)]
        public long BoxAmount { get; set; }
    }
}