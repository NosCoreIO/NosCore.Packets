using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Player
{
    [PacketHeader("tit_eq")]
    public class TitEqPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Mode { get; set; }

        [PacketIndex(1)]
        public short TitleId { get; set; }
    }
}