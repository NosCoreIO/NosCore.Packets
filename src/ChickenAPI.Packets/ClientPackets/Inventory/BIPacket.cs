using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ClientPackets.Inventory
{
    [PacketHeader("b_i")]
    public class BiPacket : PacketBase
    {
        [PacketIndex(0)]
        public PocketType PocketType { get; set; }

        [PacketIndex(1)]
        public byte Slot { get; set; }

        [PacketIndex(2, IsOptional = true)]
        public RequestDeletionType? Option { get; set; }
    }
}