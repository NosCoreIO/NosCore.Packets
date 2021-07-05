using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Instance
{
    [PacketHeader("git", Scope.InGame)]
    public class GitPacket : PacketBase
    {
        [PacketIndex(0)]
        public int ButtonId { get; set; }
    }
}
