using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Player
{
    [PacketHeader("fd")]
    public class FdPacket : IPacket
    {
        [PacketIndex(0)]
        public long Reput { get; set; }

        [PacketIndex(1)]
        public int ReputIcon { get; set; }

        [PacketIndex(2)]
        public int Dignity { get; set; }

        [PacketIndex(3)]
        public int DignityIcon { get; set; }
    }
}