//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Miniland
{
    [PacketHeader("useobj")]
    public class UseObjPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? Name { get; set; }

        [PacketIndex(1)]
        public long ObjectId { get; set; }
    }
}
