//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using System.Collections.Generic;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Battle
{
    [PacketHeader("mtlist", Scope.InGame)]
    public class MultiTargetListPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte TargetsAmount { get; set; }

        [PacketListIndex(1)]
        public List<MultiTargetListSubPacket>? Targets { get; set; }

    }
}