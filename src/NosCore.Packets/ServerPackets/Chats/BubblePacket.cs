using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Chats
{
    [PacketHeader("csp", Scope.InGame)]
    public class BubblePacket : PacketBase
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }

        [PacketIndex(1)]
        public string? Message { get; set; }
    }
}
