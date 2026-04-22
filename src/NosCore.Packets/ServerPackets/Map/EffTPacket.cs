using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Map
{
    [PacketHeader("eff_t", Scope.InGame)]
    public class EffTPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public byte Unknown1 { get; set; } //TODO to find

        [PacketIndex(3)]
        public int Unknown2 { get; set; } //TODO to find

        [PacketIndex(4)]
        public int Unknown3 { get; set; } //TODO to find
    }
}
