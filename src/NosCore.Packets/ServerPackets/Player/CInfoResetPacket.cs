using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Player
{
    [PacketHeader("c_info_reset", Scope.InGame)]
    public class CInfoResetPacket : PacketBase
    {
    }
}
