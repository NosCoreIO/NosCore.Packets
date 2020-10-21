//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ClientPackets.Battle
{
    [PacketHeader("u_s", Scope.InGame)]
    public class UseSkillPacket : PacketBase
    {
        [PacketIndex(0)]
        public long CastId { get; set; }

        [PacketIndex(1)]
        public VisualType TargetVisualType { get; set; }

        [PacketIndex(2)]
        public long TargetId { get; set; }

        [PacketIndex(3, IsOptional = true)]
        public short? MapX { get; set; }

        [PacketIndex(4, IsOptional = true)]
        public short? MapY { get; set; }
    }
}