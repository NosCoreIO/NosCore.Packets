using System.Globalization;
using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Miniland
{
    [PacketHeader("%Invite")]
    [PacketHeaderAlias("$Inviter", Flag = "FR")]
    public class PercentInvitePacket : PacketBase
    {
        [PacketIndex(0)]
        public string Username { get; set; }
    }
}