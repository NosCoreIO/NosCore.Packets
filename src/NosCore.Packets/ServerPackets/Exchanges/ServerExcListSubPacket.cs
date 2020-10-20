//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Exchanges
{
    public class ServerExcListSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public short? ExchangeSlot { get; set; }

        [PacketIndex(1, IsOptional = true)]
        public PocketType PocketType { get; set; }

        [PacketIndex(2, IsOptional = true)]
        public short ItemVnum { get; set; }

        [PacketIndex(3, IsOptional = true)]
        [Range(-2, short.MaxValue)]
        public short AmountOrRare { get; set; }

        [PacketIndex(4, IsOptional = true)]
        [Range(0, byte.MaxValue)]
        public byte Upgrade { get; set; }
    }
}