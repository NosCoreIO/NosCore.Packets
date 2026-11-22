//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.UI
{
    /// <summary>
    /// Sent at login and around NosMall use to have the server deliver what changed in the NosMall (as gift
    /// parcels); the server stays silent when nothing changed. The value has always been 50; its meaning is unknown.
    /// </summary>
    [PacketHeader("mall", Scope.InGame)]
    public class MallPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Unknown { get; set; }
    }
}
