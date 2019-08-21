using ChickenAPI.Packets.Attributes;
using System.Collections.Generic;

namespace ChickenAPI.Packets.ServerPackets.Miniland
{
    [PacketHeader("mlobjlst")]
    public class MlobjlstPacket : PacketBase
    {
        [PacketIndex(0, SpecialSeparator = ".")]
        public List<MlobjlstSubPacket> MlobjlstSubPacket { get; set; }
    }
}