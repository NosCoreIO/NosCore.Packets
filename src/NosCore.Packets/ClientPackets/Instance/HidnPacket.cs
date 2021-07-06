using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Instance
{
    [PacketHeader("hidn", Scope.InGame)]
    public class HidnPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Angle { get; set; }

        [PacketIndex(1)]
        public short PositionX { get; set; }

        [PacketIndex(2)]
        public short PositionY { get; set; }
    }
}
