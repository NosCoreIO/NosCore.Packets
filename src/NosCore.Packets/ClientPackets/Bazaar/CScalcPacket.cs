//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Bazaar
{
    [PacketHeader("c_scalc", Scope.InGame)]
    public class CScalcPacket : PacketBase
    {
        [PacketIndex(0)]
        public long BazaarId { get; set; }

        [PacketIndex(1)]
        public short VNum { get; set; }

        [PacketIndex(2)]
        [Range(0, short.MaxValue)]
        public short Amount { get; set; }

        [PacketIndex(3)]
        [Range(1, short.MaxValue)]
        public short MaxAmount { get; set; }

        [PacketIndex(4)]
        [Range(1, long.MaxValue)]
        public long Price { get; set; }
    }
}