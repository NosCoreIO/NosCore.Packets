using System.ComponentModel.DataAnnotations;
using ChickenApi.Packet.Enumerations;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("exc_list_sub_packet")]
    public class ExcListSubPacket : IPacket
    {
        [PacketIndex(0)]
        public PocketType PocketType { get; set; }

        [PacketIndex(1)]
        public short Slot { get; set; }

        [PacketIndex(2)]
        [Range(1, short.MaxValue)]
        public short Amount { get; set; }
    }
}