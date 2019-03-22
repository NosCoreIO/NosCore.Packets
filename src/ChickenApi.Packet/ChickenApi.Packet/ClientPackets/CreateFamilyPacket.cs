namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("glmk")]
    public class CreateFamilyPacket : IPacket
    {
        [PacketIndex(0)]
        public string FamilyName { get; set; }
    }
}