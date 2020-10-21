//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Relations
{
    [PacketHeader("finfo", Scope.InGame)]
    public class FinfoPacket : PacketBase
    {
        [PacketListIndex(0)]
        public List<FinfoSubPackets?>? FriendList { get; set; }
    }
}