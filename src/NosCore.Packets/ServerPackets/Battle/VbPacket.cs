//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Battle
{
    [PacketHeader("vb", Scope.InGame)]
    public class VbPacket : PacketBase
    {
        [PacketIndex(0)]
        public short CardId { get; set; }

        [PacketIndex(1)]
        public bool IsActivated { get; set; }

        [PacketIndex(2)]
        public int RemainingTime { get; set; }
    }
}