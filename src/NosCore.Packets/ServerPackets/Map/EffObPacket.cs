using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Map
{
    [PacketHeader("eff_ob", Scope.InGame)]
    public class EffObPacket : PacketBase
    {
        [PacketIndex(0)]
        public string ExtraSpace { get; set; } = string.Empty;

        [PacketIndex(1)]
        public int Unknown1 { get; set; } = -1;

        [PacketIndex(2)]
        public long Unknown2 { get; set; } = -1;

        [PacketIndex(3)]
        public bool IsVisible { get; set; }

        [PacketIndex(4)]
        public int EffectId { get; set; }
    }
}
