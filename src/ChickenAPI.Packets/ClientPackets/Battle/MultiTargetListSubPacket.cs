using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Battle
{
    [PacketHeader("multi_target_list_sub_packet")]
    public class MultiTargetListSubPacket : IPacket
    {
        [PacketIndex(0)]
        public int SkillCastId { get; set; }

        [PacketIndex(1)]
        public int TargetId { get; set; }
    }
}