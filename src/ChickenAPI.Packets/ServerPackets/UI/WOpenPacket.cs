using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ServerPackets.UI
{
    [PacketHeader("wopen")]
    public class WOpenPacket : PacketBase
    {
        [PacketIndex(0)]
        public WindowType WindowId { get; set; }

        [PacketIndex(1)]
        public byte Unknown { get; set; }

        [PacketIndex(2)]
        public byte Unknown2 { get; set; }
    }
}