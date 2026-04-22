using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Player
{
    [PacketHeader("stbm", Scope.InGame)]
    public class StbmPacket : PacketBase
    {
        [PacketIndex(0)]
        public sbyte Value { get; set; }
    }
}