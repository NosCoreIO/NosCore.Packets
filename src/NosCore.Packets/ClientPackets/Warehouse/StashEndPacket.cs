using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Warehouse
{
    [PacketHeader("stash_end", AnonymousAccess = true)]
    public class StashEndPacket : PacketBase
    {
    }
}