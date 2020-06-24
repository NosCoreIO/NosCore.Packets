//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Miniland
{
    [PacketHeader("mlo_st")]
    public class MloStPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Game { get; set; }
    }
}
