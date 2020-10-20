//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Event
{
    public class RbrSubPacketBasicInfo : PacketBase
    {
        [PacketIndex(0)]
        public short TsId { get; set; }

        [PacketIndex(1)]
        public RbrPacketTsType TsType { get; set; }

        [PacketIndex(2)]
        public RbrPacketTsConditionType TsConditionType { get; set; } //Only has meaning with a Miscelaneous TS.
    }
}