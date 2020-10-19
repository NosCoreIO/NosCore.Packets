//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets
{
    [PacketHeader("lbs")]
    public class LbsPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public int Type { get; set; }
    }
}