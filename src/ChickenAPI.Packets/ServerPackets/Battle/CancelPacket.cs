using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ServerPackets.Battle
{
    [PacketHeader("cancel")]
    public class CancelPacket : PacketBase
    {
        [PacketIndex(0)]
        public CancelPacketType Type { get; set; }

        [PacketIndex(1)]
        public long TargetId { get; set; }
    }
}