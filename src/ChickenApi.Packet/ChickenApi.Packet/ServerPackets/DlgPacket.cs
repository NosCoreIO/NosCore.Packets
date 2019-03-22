using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("dlg")]
    public class DlgPacket : IPacket
    {
        [PacketIndex(0)]
        public IPacket YesPacket { get; set; }

        [PacketIndex(1)]
        public IPacket NoPacket { get; set; }

        [PacketIndex(2)]
        public string Question { get; set; }
    }
}