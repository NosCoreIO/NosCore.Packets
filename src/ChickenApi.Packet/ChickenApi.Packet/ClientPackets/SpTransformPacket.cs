namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("sl")]
    public class SpTransformPacket : IPacket
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1, IsOptional = true)]
        public int? TransportId { get; set; }

        [PacketIndex(2, IsOptional = true)]
        public short? SpecialistDamage { get; set; }

        [PacketIndex(3, IsOptional = true)]
        public short? SpecialistDefense { get; set; }

        [PacketIndex(4, IsOptional = true)]
        public short? SpecialistElement { get; set; }

        [PacketIndex(5, IsOptional = true)]
        public short? SpecialistHP { get; set; }
    }
}