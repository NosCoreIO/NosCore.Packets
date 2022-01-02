using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Event
{
    [PacketHeader("evnt", Scope.InGame)]
    public class EventPacket
    {
        [PacketIndex(0)]
        public EventPacketType Type { get; set; }

        [PacketIndex(1)]
        public bool IsDisabled { get; set; }

        [PacketIndex(2)]
        public int Parameter { get; set; }

        [PacketIndex(3)]
        public int SecondParameter { get; set; }
    }
}
