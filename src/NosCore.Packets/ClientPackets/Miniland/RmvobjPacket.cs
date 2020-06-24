//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Miniland
{
    [PacketHeader("rmvobj")]
    public class RmvobjPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Slot { get; set; }
    }
}