//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using System.Collections.Generic;

namespace NosCore.Packets.ServerPackets.Quicklist
{
    [PacketHeader("qslot")]
    public class QSlotPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public long Slot { get; set; }

        [PacketListIndex(1)]
        public List<QsetClientSubPacket?>? Data { get; set; }
    }
}