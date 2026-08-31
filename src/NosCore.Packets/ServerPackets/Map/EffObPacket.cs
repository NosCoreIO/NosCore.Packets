using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Map
{
    [PacketHeader("eff_ob", Scope.InGame)]
    public class EffObPacket : PacketBase
    {
        // The client reads only the FIRST CHARACTER of this field.
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public bool IsVisible { get; set; }

        [PacketIndex(3)]
        public int EffectId { get; set; }
    }
}
