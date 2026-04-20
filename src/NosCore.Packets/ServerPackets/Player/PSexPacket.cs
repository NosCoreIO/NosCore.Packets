//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Player
{
    // Partner gender display. Sent when a mate/partner is summoned so the client
    // picks the correct mate sprite.
    [PacketHeader("p_sex", Scope.InGame)]
    public class PSexPacket : PacketBase
    {
        [PacketIndex(0)]
        public GenderType Gender { get; set; }
    }
}
