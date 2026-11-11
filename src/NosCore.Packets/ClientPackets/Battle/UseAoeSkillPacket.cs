//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Battle
{
    [PacketHeader("u_as", Scope.InGame)]
    public class UseAoeSkillPacket : PacketBase
    {
        [PacketIndex(0)]
        public long CastId { get; set; }

        [Range(0, short.MaxValue)]
        [PacketIndex(1)]
        public short MapX { get; set; }

        [Range(0, short.MaxValue)]
        [PacketIndex(2)]
        public short MapY { get; set; }
    }
}