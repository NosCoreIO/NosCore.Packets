//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Warehouse
{
    [PacketHeader("withdraw", Scope.InGame | Scope.InTrade)]
    public class WithdrawPacket : PacketBase
    {
        [Range(0, short.MaxValue)]
        [PacketIndex(0)]
        public short Slot { get; set; }

        [Range(1, short.MaxValue)]
        [PacketIndex(1)]
        public short Amount { get; set; }

        [PacketIndex(2)]
        public bool PetBackpack { get; set; }
    }
}