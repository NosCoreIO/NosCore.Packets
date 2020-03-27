using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.UI
{
    [PacketHeader("guri")]
    public class GuriPacket : PacketBase
    {
        [PacketIndex(0)]
        public GuriPacketType Type { get; set; }

        [PacketIndex(1)]
        public uint Unknown { get; set; } // seems to be a visual type or something

        [PacketIndex(2)]
        public long EntityId { get; set; }

        [PacketIndex(3)]
        public uint Value { get; set; }
    }
}