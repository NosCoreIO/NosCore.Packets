using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Shop
{
    [PacketHeader("sopen", Scope.InGame)]
    public class SopenPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }
    }
}
