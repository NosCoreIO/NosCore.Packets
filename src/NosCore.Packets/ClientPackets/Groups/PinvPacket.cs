//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Groups
{
    [PacketHeader("pinv", Scope.InGame)]
    public class PinvPacket : PacketBase
    {
        public PinvPacket(string characterName)
        {
            CharacterName = characterName;
        }

        [PacketIndex(0)]
        public string CharacterName { get; set; }
    }
}