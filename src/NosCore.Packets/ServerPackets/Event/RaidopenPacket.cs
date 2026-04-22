using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Event
{
    [PacketHeader("raidopen", Scope.InGame)]
    public class RaidopenPacket : PacketBase
    {
    }
}
