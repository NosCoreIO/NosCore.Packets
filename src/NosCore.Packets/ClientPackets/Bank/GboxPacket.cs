//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Bank
{
    [PacketHeader("gbox", Scope.InGame)]
    public class GboxPacket : PacketBase
    {
        [PacketIndex(0)]
        public BankActionType Type { get; set; }

        [PacketIndex(1)]
        [Range(0, long.MaxValue)]
        public long Amount { get; set; }

        [PacketIndex(2)]
        public bool Mode { get; set; }
    }
}
