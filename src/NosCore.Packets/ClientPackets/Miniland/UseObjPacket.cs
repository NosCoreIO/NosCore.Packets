//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Miniland
{
    [PacketHeader("useobj", Scope.InGame)]
    public class UseObjPacket : PacketBase
    {
        [PacketIndex(0)]
        [Required]
        public string CharacterName { get; set; } = null!;

        [PacketIndex(1)]
        public short Slot { get; set; }
    }
}
