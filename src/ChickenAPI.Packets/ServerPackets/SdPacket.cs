using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("sd")]
    public class SdPacket : IPacket
    {
        [PacketIndex(0)]
        public short Cooldown { get; set; }
    }
}