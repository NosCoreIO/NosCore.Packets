//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Arena
{
    // Marks the fighter currently in the ring in one of the team arena lists.
    [PacketHeader("ta_fc", Scope.InGame)]
    public class TaFcPacket : PacketBase
    {
        [PacketIndex(0)]
        public ArenaSideType Side { get; set; }

        [PacketIndex(1)]
        public long CharacterId { get; set; }
    }
}
