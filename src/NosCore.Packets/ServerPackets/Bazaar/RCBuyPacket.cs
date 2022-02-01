//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Shared.Enumerations;
using System.ComponentModel.DataAnnotations;

namespace NosCore.Packets.ServerPackets.Bazaar
{
    [PacketHeader("rc_buy", Scope.InGame)]
    public class RCBuyPacket : PacketBase
    {
        public RCBuyPacket(string owner)
        {
            Owner = owner;
        }

        [PacketIndex(0)]
        public VisualType Type { get; set; }

        [PacketIndex(1)]
        public short VNum { get; set; }

        [PacketIndex(2)]
        public string Owner { get; set; }

        [PacketIndex(3)]
        public short Amount { get; set; }

        [PacketIndex(4)]
        public long Price { get; set; }

        [PacketIndex(5)]
        public short Slot { get; set; }

        [PacketIndex(6)]
        public byte Upgrade { get; set; }

        [PacketIndex(7)]
        public byte Rarity { get; set; }
    }
}