using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Specialists
{
    [PacketHeader("sp")]
    public class SpPacket : PacketBase
    {
        [PacketIndex(0)]
        public int AdditionalPoint { get; set; }

        [PacketIndex(1)]
        public int MaxAdditionalPoint { get; set; }

        [PacketIndex(2)]
        public int SpPoint { get; set; }

        [PacketIndex(3)]
        public int MaxSpPoint { get; set; }
    }
}