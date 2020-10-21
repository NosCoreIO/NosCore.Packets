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
    [PacketHeader("c_reg", Scope.InGame)]
    public class CRegPacket : PacketBase
    {
        [PacketIndex(0)]
        public int Type { get; set; }
        [PacketIndex(1)]
        [Range(0, 4)] // won't use an enum because of the 4
        public byte Inventory { get; set; }
        [PacketIndex(2)]
        public byte Slot { get; set; }
        [PacketIndex(3)]
        public int Unknown1 { get; set; }
        [PacketIndex(4)]
        public int Unknown2 { get; set; }
        [PacketIndex(5)]
        [Range(0, 4)]
        public byte Durability { get; set; }
        [PacketIndex(6)]
        public bool IsPackage { get; set; }
        [PacketIndex(7)]
        [Range(1, short.MaxValue)]
        public short Amount { get; set; }
        [PacketIndex(8)]
        [Range(1, long.MaxValue)]
        public long Price { get; set; }
        [PacketIndex(9)]
        public int Taxe { get; set; }
        [PacketIndex(10)]
        public byte MedalUsed { get; set; }
    }
}