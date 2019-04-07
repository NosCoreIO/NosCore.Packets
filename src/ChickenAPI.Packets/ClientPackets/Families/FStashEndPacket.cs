using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Families
{
    [PacketHeader("f_stash_end")]
    public class FStashEndPacket : IPacket
    {
    }
}