using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Shop
{
    [PacketHeader("n_inv_skills")]
    public class NInvFamilySkillSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public short SkillId { get; set; }

        [PacketIndex(1)]
        public byte Type { get; set; }

        [PacketIndex(2)]
        public byte Slot { get; set; }
    }
}