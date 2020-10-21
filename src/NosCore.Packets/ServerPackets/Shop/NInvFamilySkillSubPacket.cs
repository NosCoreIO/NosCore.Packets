//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Shop
{
    [PacketHeader("n_inv_skills", Scope.InGame)]
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