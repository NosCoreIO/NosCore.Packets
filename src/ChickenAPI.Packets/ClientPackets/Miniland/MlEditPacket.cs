using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ClientPackets.Miniland
{
    [PacketHeader("mledit")]
    public class MLEditPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1, IsOptional = true)]
        public MinilandState? Parameter { get; set; }

        [PacketIndex(2, IsOptional = true)]
        public string MinilandInfo { get; set; }
    }
}
