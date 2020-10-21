//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Shops
{
    [PacketHeader("sell", Scope.InGame)]
    public class SellPacket : PacketBase
    {
        [PacketIndex(2)]
        public short Data { get; set; }

        [PacketIndex(3)]
        [Range(0, byte.MaxValue)]
        public byte Slot { get; set; }

        [PacketIndex(4)]
        [Range(1, short.MaxValue)]
        public short Amount { get; set; }
    }
}