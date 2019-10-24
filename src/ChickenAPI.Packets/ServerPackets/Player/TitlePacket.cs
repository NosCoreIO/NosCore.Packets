using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Player
{
    [PacketHeader("title")]
    public class TitlePacket : PacketBase
    {
        [PacketIndex(0, IsOptional = true)]
        public List<TitleSubPacket> Data { get; set; }
    }
}