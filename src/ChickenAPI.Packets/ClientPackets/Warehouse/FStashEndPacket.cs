using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Warehouse
{
    [PacketHeader("f_stash_end", AnonymousAccess = true)]
    public class FStashEndPacket : PacketBase
    {
    }
}