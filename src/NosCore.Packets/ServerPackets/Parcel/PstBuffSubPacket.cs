//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Parcel
{
    [PacketHeader("pst_buff_sub_packet", Scope.InGame)]
    public class PstBuffSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public short CardId { get; set; }

        [PacketIndex(1)]
        public byte Level { get; set; }
    }
}
