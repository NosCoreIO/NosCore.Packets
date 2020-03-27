using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Shops
{
    [PacketHeader("c_close", AnonymousAccess = true)]
    public class CClosePacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }
    }
}