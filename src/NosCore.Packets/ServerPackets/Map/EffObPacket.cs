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
        public short MapX { get; set; }

        [PacketIndex(2)]
        public short MapY { get; set; }

        [PacketIndex(3)]
        public byte Unknown { get; set; } //TODO to find

        [PacketIndex(4)]
        public int EffectId { get; set; }
    }
}
