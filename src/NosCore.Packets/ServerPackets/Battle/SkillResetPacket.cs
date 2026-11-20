//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Battle
{
    [PacketHeader("sr", Scope.InGame)]
    public class SkillResetPacket : PacketBase
    {
        [PacketIndex(0)]
        public long CastId { get; set; }

        // Only seen with a cast id of -10, after a refused capture.
        [PacketIndex(1, IsOptional = true)]
        public short? Unknown1 { get; set; }

        [PacketIndex(2, IsOptional = true)]
        public short? Unknown2 { get; set; }
    }
}
