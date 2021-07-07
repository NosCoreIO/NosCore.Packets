//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Arena
{
    [PacketHeader("ta_call", Scope.InGame)]
    public class TaCallPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte CalledIndex { get; set; }
    }
}
