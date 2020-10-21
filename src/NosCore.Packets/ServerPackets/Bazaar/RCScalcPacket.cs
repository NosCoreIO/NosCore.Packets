//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Bazaar
{
    [PacketHeader("rc_scalc", Scope.InGame)]
    public class RCScalcPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType Type { get; set; }
        [PacketIndex(1)]
        [Range(1, long.MaxValue)]
        public long Price { get; set; }
        [PacketIndex(2)]
        public short RemainingAmount { get; set; }
        [PacketIndex(3)]
        public short Amount { get; set; }
        [PacketIndex(4)]
        public short Taxes { get; set; }
        [PacketIndex(5)]
        public long Total { get; set; }
    }
}