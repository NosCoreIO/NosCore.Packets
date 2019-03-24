using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("sp")]
    public class SpPacket : IPacket
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