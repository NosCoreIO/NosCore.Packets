using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Shops
{
    [PacketHeader("c_close", AnonymousAccess = true)]
    public class CClosePacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }
    }
}