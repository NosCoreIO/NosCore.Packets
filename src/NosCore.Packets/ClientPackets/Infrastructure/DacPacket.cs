//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Infrastructure
{
    [PacketHeader("DAC", AnonymousAccess = true)]
    public class DacPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public string AccountName { get; set; } = null!;

        [PacketIndex(1)]
        [Range(0, 3)]
        public byte Slot { get; set; }

    }
}
