//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Battle
{
    [PacketHeader("cancel")]
    public class CancelPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public CancelPacketType Type { get; set; }

        [PacketIndex(1)]
        public long TargetId { get; set; }
    }
}