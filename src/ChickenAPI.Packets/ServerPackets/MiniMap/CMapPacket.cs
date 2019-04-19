using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Minimap
{
    [PacketHeader("c_map")]
    public class CMapPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1)]
        public short Id { get; set; }

        [PacketIndex(2)]
        public bool MapType { get; set; }
    }
}