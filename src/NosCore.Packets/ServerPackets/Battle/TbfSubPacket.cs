using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Battle
{
    public class TbfSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Major { get; set; }

        [PacketIndex(1)]
        public byte Minor { get; set; }
    }
}
