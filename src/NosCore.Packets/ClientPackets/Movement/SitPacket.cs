//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Movement
{
    [PacketHeader("rest", Scope.InGame | Scope.InExchange)]
    public class SitPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Amount { get; set; }

        [PacketListIndex(1, Length = -1)]
        public List<SitSubPacket?>? Users { get; set; }
    }
}