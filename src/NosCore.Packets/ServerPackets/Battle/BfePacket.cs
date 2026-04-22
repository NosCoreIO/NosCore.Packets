//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Battle
{
    // Sent to the target and the surrounding map when a buff/debuff expires so the
    // client drops the icon + any applied visual effect. Mirror of BfPacket which
    // signals the inverse (buff applied / refreshed).
    [PacketHeader("bf_e", Scope.InGame)]
    public class BfePacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public short CardId { get; set; }

        [PacketIndex(3)]
        public short Unknown { get; set; } //TODO to find
    }
}
