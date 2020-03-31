using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Player
{
    [PacketHeader("npinfo")]
    public class NpInfoPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Page { get; set; }
    }
}