using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Mates
{
    [PacketHeader("ps_op")]
    public class PsopPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte PetSlot { get; set; }

        [PacketIndex(1)]
        public byte SkillSlot { get; set; }

        [PacketIndex(2)]
        public byte Option { get; set; }
    }
}