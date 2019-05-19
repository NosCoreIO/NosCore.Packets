using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.UI
{
    [PacketHeader("dlg")]
    public class DialogPacket : PacketBase
    {
        [PacketIndex(0)]
        public IPacket AcceptPacket { get; set; }

        [PacketIndex(1)]
        public IPacket RefusePacket { get; set; }

        [PacketIndex(2)]
        public string Question { get; set; }
    }
}