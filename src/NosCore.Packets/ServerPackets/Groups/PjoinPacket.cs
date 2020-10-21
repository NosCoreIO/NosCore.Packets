//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Groups
{
    [PacketHeader("pjoin", Scope.InGame)]
    public class PjoinPacket : PacketBase
    {
        [PacketIndex(0)]
        public GroupRequestType RequestType { get; set; }

        [PacketIndex(1)]
        [Range(0, long.MaxValue)]
        public long CharacterId { get; set; }
    }
}