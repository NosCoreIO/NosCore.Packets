//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.CharacterSelectionScreen
{
    [PacketHeader("Char_NEW_JOB", Scope.OnCharacterScreen)]
    public class CharNewJobPacket : CharNewPacket
    {
        public CharNewJobPacket()
        {
            IsMartialArtist = true;
        }
    }
}