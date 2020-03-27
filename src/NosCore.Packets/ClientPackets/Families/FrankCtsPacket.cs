using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Families
{
    [PacketHeader("frank_cts")]
    public class FrankCtsPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }
    }
}