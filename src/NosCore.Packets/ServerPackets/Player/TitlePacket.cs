using System.Collections.Generic;
using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Player
{
    [PacketHeader("title")]
    public class TitlePacket : PacketBase
    {
        [PacketIndex(0, IsOptional = true)]
        public List<TitleSubPacket?>? Data { get; set; }
    }
}