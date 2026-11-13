using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Chats
{
    [PacketHeader("csp", Scope.InGame)]
    public class BubblePacket : PacketBase
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }

        // The client turns each vertical tab back into a space.
        [PacketIndex(1, EscapeSpaces = true, SpaceEscape = "\v")]
        public string? Message { get; set; }
    }
}
