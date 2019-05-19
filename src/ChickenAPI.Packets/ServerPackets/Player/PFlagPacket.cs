using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ServerPackets.Player
{
    [PacketHeader("pflag")]
    public class PFlagPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType EntityType { get; set; }

        [PacketIndex(1)]
        public long EntityId { get; set; }

        [PacketIndex(2)]
        public long ShopId { get; set; }
    }
}