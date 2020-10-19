//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Entities
{
    [PacketHeader("req_info")]
    public class ReqInfoPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public ReqInfoType ReqType { get; set; }

        [PacketIndex(1)]
        public long TargetVNum { get; set; }

        [PacketIndex(2)]
        public int? MateVNum { get; set; }
    }
}