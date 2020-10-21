//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ClientPackets.Npcs
{
    [PacketHeader("n_run", Scope.InGame)]
    public class NrunPacket : PacketBase
    {
        [PacketIndex(0)]
        public NrunRunnerType Runner { get; set; }

        [PacketIndex(1, IsOptional = true)]
        public short? Type { get; set; }

        [PacketIndex(2, IsOptional = true)]
        public VisualType? VisualType { get; set; }

        [PacketIndex(3, IsOptional = true)]
        public long? VisualId { get; set; }
    }
}