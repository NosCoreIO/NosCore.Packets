using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Event
{
    [PacketHeader("fbt", Scope.InGame)]
    public class FbtPacket
    {
        [PacketIndex(0)]
        public byte Type { get; set; }
        [PacketIndex(1)]
        public long Argument { get; set; }
        [PacketIndex(2)]
        public byte? Parameter { get; set; }
        [PacketIndex(3)]
        public short? SecondParameter { get; set; }
    }
}
