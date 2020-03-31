using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Specialists
{
    [PacketHeader("sd")]
    public class SdPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Cooldown { get; set; }
    }
}