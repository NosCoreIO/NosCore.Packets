//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Battle
{
    [PacketHeader("psr", Scope.InGame)]
    public class PsrPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Unknown { get; set; }
    }
}
