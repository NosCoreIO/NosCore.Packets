using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.MiniMap
{
    [PacketHeader("wp", Scope.InGame)]
    public class WpPacket : PacketBase
    {
        [PacketIndex(0)]
        public short PositionX { get; set; }

        [PacketIndex(1)]
        public short PositionY { get; set; }

        [PacketIndex(2)]
        public short ScriptedInstanceId { get; set; }

        [PacketIndex(3)]
        public WpPortalType PortalType { get; set; }

        [PacketIndex(4)]
        public byte LevelMinimum { get; set; }

        [PacketIndex(5)]
        public byte LevelMaximum { get; set; }
    }
}
