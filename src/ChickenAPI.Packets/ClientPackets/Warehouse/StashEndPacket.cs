using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Warehouse
{
    [PacketHeader("stash_end", AnonymousAccess = true)]
    public class StashEndPacket : PacketBase
    {
    }
}