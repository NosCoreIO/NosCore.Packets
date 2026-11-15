//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.RainbowBattle
{
    // The character ids of the receiver's Rainbow Battle team; the client keeps up to 40.
    [PacketHeader("fbt", Scope.InGame, AllowDuplicateHeader = true)]
    public class FbtMembersPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; } = 0;

        [PacketListIndex(1, ListSeparator = " ")]
        public List<long> CharacterIds { get; set; } = new();
    }
}
