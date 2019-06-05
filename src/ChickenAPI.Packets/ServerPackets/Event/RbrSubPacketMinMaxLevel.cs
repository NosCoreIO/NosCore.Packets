using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Event
{
    public class RbrSubPacketMinMaxLevel : PacketBase
    {
        [PacketIndex(0)]
        public byte MinLevel { get; set; }

        [PacketIndex(1)]
        public byte MaxLevel { get; set; }
    }
}