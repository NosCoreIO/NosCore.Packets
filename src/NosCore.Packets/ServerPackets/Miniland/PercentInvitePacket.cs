using System.Globalization;
using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Miniland
{
    [PacketHeader("%Invite")]
    [PacketHeaderAlias("$Inviter", Flag = "FR")]
    public class PercentInvitePacket : PacketBase
    {
        [PacketIndex(0)]
        public string? Username { get; set; }
    }
}