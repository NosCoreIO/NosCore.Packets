using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Families
{
    [PacketHeader("frank_cts")]
    public class FrankCtsPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }
    }
}