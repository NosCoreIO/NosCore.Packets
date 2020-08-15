//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Visibility
{
    public class InFamily : PacketBase
    {
        [PacketIndex(0, IsOptional = true)]
        public long? Id { get; set; } // FamilyId

        [PacketIndex(1)]
        public int Title { get; set; }
    }
}
