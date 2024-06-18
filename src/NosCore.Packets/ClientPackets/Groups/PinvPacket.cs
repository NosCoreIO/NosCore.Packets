//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

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