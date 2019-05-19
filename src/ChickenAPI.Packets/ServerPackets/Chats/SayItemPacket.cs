using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.ServerPackets.Inventory;

namespace ChickenAPI.Packets.ServerPackets.Chats
{
    [PacketHeader("sayitem")]
    public class SayItemPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public byte OratorSlot { get; set; }


        [PacketIndex(3)]
        public string GlobalPrefix { get; set; }

        [PacketIndex(4)]
        public string CharacterName { get; set; }

        [PacketIndex(5)]
        public string ItemName { get; set; }

        /// <summary>
        /// Spaces should be replaced by '^'
        /// </summary>
        [PacketIndex(6, IsOptional = true)]
        public string Message { get; set; }


        [PacketIndex(6, IsOptional = true)]
        public SayItemSubPacket ItemData { get; set; }

        [PacketIndex(7, IsOptional = true)]
        public EInfoPacket EquipmentInfo { get; set; }

        [PacketHeader("ItemInfo ")]
        public class SayItemSubPacket : PacketBase
        {
            // disgusting but it's entwell
            // :hap:
            [PacketIndex(0, IsOptional = true)]
            public long? IconId { get; set; }
        }
    }
}