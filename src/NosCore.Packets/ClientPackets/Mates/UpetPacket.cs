//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ClientPackets.Mates
{
    [PacketHeader("u_pet", Scope.InGame)]
    [MinimumInterval(Milliseconds = 100)]
    public class UpetPacket : PacketBase
    {
        [PacketIndex(0)]
        public long MateTransportId { get; set; }

        [PacketIndex(1)]
        public VisualType TargetType { get; set; }

        [PacketIndex(2)]
        public long TargetId { get; set; }

        [PacketIndex(3)]
        public short SkillVNum { get; set; }

        [PacketIndex(4, IsOptional = true)]
        public short? MapX { get; set; }

        [PacketIndex(5, IsOptional = true)]
        public short? MapY { get; set; }
    }
}