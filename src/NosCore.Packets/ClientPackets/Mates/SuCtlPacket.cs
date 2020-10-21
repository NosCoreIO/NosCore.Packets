//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ClientPackets.Mates
{
    [PacketHeader("suctl", Scope.InGame)]
    public class SuCtlPacket : PacketBase
    {
        [PacketIndex(0)]
        public int CastId { get; set; }

        [PacketIndex(1)]
        public int Unknown2 { get; set; }

        [PacketIndex(2)]
        public long MateTransportId { get; set; }

        [PacketIndex(3)]
        public VisualType TargetType { get; set; }

        [PacketIndex(4)]
        public long TargetId { get; set; }
    }
}