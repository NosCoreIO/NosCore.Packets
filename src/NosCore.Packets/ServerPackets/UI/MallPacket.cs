using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.UI
{
    [PacketHeader("mall", Scope.InGame)]
    public class MallPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte State { get; set; }
    }
}
