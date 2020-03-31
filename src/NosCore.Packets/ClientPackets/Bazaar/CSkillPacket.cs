using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Bazaar
{
    [PacketHeader("c_skill", BlockedByTrading = true)]
    public class CSkillPacket : PacketBase
    {
    }
}