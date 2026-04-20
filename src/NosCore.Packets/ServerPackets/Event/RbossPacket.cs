//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Event
{
    // Raid boss HP bar update. Type tends to be 3 during the live fight in OpenNos
    // (status = active); 0 hides the bar. MapMonsterId + HP values drive the visual
    // so the raid party can see the boss's remaining health.
    [PacketHeader("rboss", Scope.InGame)]
    public class RbossPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1)]
        public int MapMonsterId { get; set; }

        [PacketIndex(2)]
        public int CurrentHp { get; set; }

        [PacketIndex(3)]
        public int MaxHp { get; set; }
    }
}
