using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Map
{  
    [PacketHeader("eff_g")]
    public class GroundEffectPacket : PacketBase
    {
        [PacketIndex(0)]
        public char ExtraSpace { get; set; } = '\0';

        [PacketIndex(1)]
        public ushort Effect { get; set; }

        [PacketIndex(2)]
        public string XYCoordinates { get; set; }

        [PacketIndex(3)]
        public ushort MapX { get; set; }

        [PacketIndex(4)]
        public ushort MapY { get; set; }

        [PacketIndex(5)]
        public bool IsRemoval { get; set; }
    }
}
