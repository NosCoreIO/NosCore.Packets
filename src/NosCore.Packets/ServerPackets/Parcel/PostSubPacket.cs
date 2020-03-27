using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.ServerPackets.Visibility;

namespace NosCore.Packets.ServerPackets.Parcel
{
    public class PostSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public CharacterClassType Class { get; set; }

        [PacketIndex(1)]
        public GenderType Gender { get; set; }

        [PacketIndex(2)]
        public short MorphId { get; set; }

        [PacketIndex(3)]
        public HairStyleType HairStyle { get; set; }

        [PacketIndex(4)]
        public HairColorType HairColor { get; set; }

        [PacketIndex(5, SpecialSeparator = ".")]
        public InEquipmentSubPacket? Equipment { get; set; }
    }
}