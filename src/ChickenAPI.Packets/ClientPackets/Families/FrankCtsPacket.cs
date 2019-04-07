using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Families
{
    [PacketHeader("frank_cts")]
    public class FrankCtsPacket : IPacket
    {
        [PacketIndex(0)]
        public byte Type { get; set; }
    }
}