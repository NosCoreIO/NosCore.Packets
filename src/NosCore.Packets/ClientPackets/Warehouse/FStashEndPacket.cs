using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Warehouse
{
    [PacketHeader("f_stash_end", AnonymousAccess = true)]
    public class FStashEndPacket : PacketBase
    {
    }
}