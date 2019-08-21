using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Families
{
    [PacketHeader("f_stash_end", AnonymousAccess = true)]
    public class FStashEndPacket : PacketBase
    {
    }
}