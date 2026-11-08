//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Families
{
    // Tells a family member the history changed, so the client asks again with fhis_cts.
    [PacketHeader("fhis_stc", Scope.InGame)]
    public class FhisStcPacket : PacketBase
    {
    }
}
