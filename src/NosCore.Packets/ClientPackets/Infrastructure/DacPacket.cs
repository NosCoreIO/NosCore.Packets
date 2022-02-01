//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Infrastructure
{
    [PacketHeader("DAC", Scope.OnCharacterScreen)]
    public class DacPacket : PacketBase
    {
        public DacPacket(string accountName)
        {
            AccountName = accountName;
        }

        [PacketIndex(0)]
        public string AccountName { get; set; }

        [PacketIndex(1)]
        [Range(0, 3)]
        public byte Slot { get; set; }

    }
}
