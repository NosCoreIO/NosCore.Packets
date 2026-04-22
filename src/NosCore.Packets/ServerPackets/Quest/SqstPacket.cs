using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Quest
{
    [PacketHeader("sqst", Scope.InGame)]
    public class SqstPacket : PacketBase
    {
        [PacketIndex(0)]
        public string ExtraSpace { get; set; } = string.Empty;

        [PacketIndex(1)]
        public byte Type { get; set; }

        [PacketIndex(2)]
        public string? Bitmap { get; set; }
    }
}
