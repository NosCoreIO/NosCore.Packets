namespace ChickenApi.Packet.ServerPackets
{
    public class InItemSubPacket : IPacket
    {
        [PacketIndex(0)]
        public int Amount { get; set; }

        [PacketIndex(1)]
        public bool IsQuestRelative { get; set; }

        [PacketIndex(2)]
        public long Owner { get; set; }
    }
}