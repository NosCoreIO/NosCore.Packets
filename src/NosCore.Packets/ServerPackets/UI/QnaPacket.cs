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
    [PacketHeader("qna", Scope.InGame)]
    public class QnaPacket : PacketBase
    {
        [PacketIndex(0)]
        public IPacket? YesPacket { get; set; }

        [PacketIndex(1)]
        public string? Question { get; set; }
    }
}