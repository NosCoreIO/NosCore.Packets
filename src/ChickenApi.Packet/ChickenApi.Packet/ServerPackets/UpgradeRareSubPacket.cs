namespace ChickenApi.Packet.ServerPackets
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