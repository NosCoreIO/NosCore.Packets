namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("in_item_subpacket")]
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