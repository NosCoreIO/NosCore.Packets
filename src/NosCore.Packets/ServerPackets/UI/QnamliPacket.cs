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
    // A question the client parks as a notification icon instead of opening it at once; the
    // YesPacket is sent back when the player accepts.
    [PacketHeader("qnamli", Scope.InGame)]
    public class QnamliPacket : PacketBase
    {
        [PacketIndex(0)]
        public QnamlType Type { get; set; }

        [PacketIndex(1)]
        public IPacket? YesPacket { get; set; }

        [PacketIndex(2)]
        public Game18NConstString Question { get; set; }

        [PacketIndex(3)]
        public byte ArgumentType { get; set; }

        [PacketIndex(4)]
        public Game18NArguments Game18NArguments { get; set; } = new(2);
    }
}
