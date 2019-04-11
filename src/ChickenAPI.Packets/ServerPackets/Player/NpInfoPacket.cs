using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Player
{
    [PacketHeader("npinfo")]
    public class NpInfoPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Page { get; set; }
    }
}