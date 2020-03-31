using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Chat
{
    [PacketHeader("btk")]
    public class BtkPacket : PacketBase
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }

        [PacketIndex(1)]
        public string? Message { get; set; }
    }
}