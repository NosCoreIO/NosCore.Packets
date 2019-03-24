using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("upgrade_rare_sub_packet")]
    public class UpgradeRareSubPacket : IPacket
    {
        [PacketIndex(0)]
        public byte Upgrade { get; set; }

        [PacketIndex(1)]
        public byte Rare { get; set; }
    }
}