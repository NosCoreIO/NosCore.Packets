using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Movement
{
    [PacketHeader("walk")]
    public class WalkPacket : PacketBase
    {
        [PacketIndex(0)]
        public short XCoordinate { get; set; }

        [PacketIndex(1)]
        public short YCoordinate { get; set; }

        [PacketIndex(2)]
        public short Unknown { get; set; } //TODO to find

        [PacketIndex(3)]
        public short Speed { get; set; }
    }
}