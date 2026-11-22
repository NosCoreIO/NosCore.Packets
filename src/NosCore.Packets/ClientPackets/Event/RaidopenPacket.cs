//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Event
{
    // Sent when the player opens the raid window; the server answers with the raid pocket's inv line.
    [PacketHeader("raidopen", Scope.InGame)]
    public class RaidopenPacket : PacketBase
    {
    }
}
