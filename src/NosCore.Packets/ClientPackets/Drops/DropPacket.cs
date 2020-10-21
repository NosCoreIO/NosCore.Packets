//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Drops
{
    [PacketHeader("drop", Scope.InGame)]
    internal class DropPacket : PacketBase
    {
        [PacketIndex(0)]
        public long ItemVNum { get; set; }

        [PacketIndex(1)]
        public long DropId { get; set; }

        [PacketIndex(2)]
        public short MapX { get; set; }

        [PacketIndex(3)]
        public short MapY { get; set; }

        [PacketIndex(4)]
        public short Amount { get; set; }

        [PacketIndex(5)]
        public bool IsQuestItem { get; set; }

        [PacketIndex(6)]
        public byte Mode { get; set; } // looks like always 0

        [PacketIndex(7)]
        public byte Parametrer { get; set; } // looks like always -1
    }
}