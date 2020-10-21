//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.UI
{
    [PacketHeader("bsinfo", Scope.InGame)]
    public class BSInfoPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Mode { get; set; }

        [PacketIndex(1)]
        public short Title { get; set; }

        [PacketIndex(2)]
        public short Time { get; set; }

        [PacketIndex(3)]
        public short Text { get; set; }
    }
}