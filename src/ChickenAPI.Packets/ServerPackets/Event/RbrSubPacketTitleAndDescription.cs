using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Event
{
    public class RbrSubPacketTitleAndDescription : PacketBase
    {
        [PacketIndex(0)]
        public string Title { get; set; }

        [PacketIndex(1)]
        public string Description { get; set; }
    }
}