using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Login
{
    public class ClientVersionSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Major { get; set; }

        [PacketIndex(1)]
        public byte Minor { get; set; }

        [PacketIndex(2)]
        public short Fix { get; set; }

        [PacketIndex(3)]
        public short SubFix { get; set; }
    }
}