//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Families
{
    [PacketHeader("glmk", Scope.InGame)]
    public class CreateFamilyPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? FamilyName { get; set; }
    }
}