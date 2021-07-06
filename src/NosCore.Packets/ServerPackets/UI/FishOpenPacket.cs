using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.UI
{
    [PacketHeader("fishopen", Scope.InGame)]
    public class FishOpenPacket : PacketBase
    {
    }
}
