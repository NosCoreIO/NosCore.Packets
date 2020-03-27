using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.UI
{
    [PacketHeader("dlg")]
    public class DlgPacket : PacketBase
    {
        [PacketIndex(0)]
        public IPacket? YesPacket { get; set; }

        [PacketIndex(1)]
        public IPacket? NoPacket { get; set; }

        [PacketIndex(2)]
        public string? Question { get; set; }
    }
}