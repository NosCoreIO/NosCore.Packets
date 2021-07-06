using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.UI
{
    [PacketHeader("ta_close", Scope.InGame)]
    public class TeamArenaClosePacket : PacketBase
    {
    }
}
