using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Passion
{
    [PacketHeader("fish", Scope.InGame)]
    public class FishPacket : PacketBase
    {
        [PacketIndex(0)]
        public FishPacketType FishType { get; set; }

        [PacketIndex(1)]
        public byte FishId { get; set; }

        [PacketIndex(2)]
        public short FishCount { get; set; }

        [PacketIndex(3)]
        public byte MaxLength { get; set; }
    }
}
