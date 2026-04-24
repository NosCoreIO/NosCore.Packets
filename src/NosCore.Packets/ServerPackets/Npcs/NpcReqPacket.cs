//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Npcs
{
    /// <summary>
    /// Server-side NPC request packet, observed as e.g. <c>npc_req 2 5140 16</c>.
    /// Mirrors the client-side <see cref="NosCore.Packets.ClientPackets.Npcs.RequestNpcPacket"/>.
    /// </summary>
    [PacketHeader("npc_req", Scope.InGame)]
    public class NpcReqPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType Type { get; set; }

        [PacketIndex(1)]
        public long TargetId { get; set; }

        [PacketIndex(2)]
        public long? Data { get; set; }
    }
}
