//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Shops
{
    [PacketHeader("c_close", AnonymousAccess = true)]
    public class CClosePacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public byte Type { get; set; }
    }
}