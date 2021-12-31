//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.UI
{
    [PacketHeader("umi", Scope.InGame)]
    public class UmiPacket : PacketBase
    {
        [PacketIndex(0)]
        public short ItemVNum { get; set; }

        [PacketIndex(1)]
        public int Time { get; set; }
    }
}