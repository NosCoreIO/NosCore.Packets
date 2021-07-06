using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Instance
{
    [PacketHeader("escape", Scope.InGame)]
    public class EscapePacket : PacketBase
    {
    }
}
