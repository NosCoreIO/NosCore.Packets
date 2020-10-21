//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Mates
{
    [PacketHeader("ps_op", Scope.InGame)]
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