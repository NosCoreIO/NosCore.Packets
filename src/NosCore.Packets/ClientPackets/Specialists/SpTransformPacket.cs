//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Specialists
{
    [PacketHeader("sl", Scope.InGame)]
    public class SpTransformPacket : PacketBase
    {
        [PacketIndex(0)]
        public SlPacketType Type { get; set; }

        [PacketIndex(1, IsOptional = true)]
        public int? TransportId { get; set; }

        [PacketIndex(2, IsOptional = true)]
        public short? SpecialistDamage { get; set; }

        [PacketIndex(3, IsOptional = true)]
        public short? SpecialistDefense { get; set; }

        [PacketIndex(4, IsOptional = true)]
        public short? SpecialistElement { get; set; }

        [PacketIndex(5, IsOptional = true)]
        public short? SpecialistHP { get; set; }
    }
}