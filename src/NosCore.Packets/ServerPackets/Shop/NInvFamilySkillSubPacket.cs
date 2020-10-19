//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Shop
{
    [PacketHeader("n_inv_skills")]
    public class NInvFamilySkillSubPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public short SkillId { get; set; }

        [PacketIndex(1)]
        public byte Type { get; set; }

        [PacketIndex(2)]
        public byte Slot { get; set; }
    }
}