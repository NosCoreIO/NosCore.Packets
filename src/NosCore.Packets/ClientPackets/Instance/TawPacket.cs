using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Instance
{
    [PacketHeader("taw", Scope.InGame)]
    public class TawPacket : PacketBase
    {
        [PacketIndex(0)]
        public string Username { get; set; } = null!;
    }
}
