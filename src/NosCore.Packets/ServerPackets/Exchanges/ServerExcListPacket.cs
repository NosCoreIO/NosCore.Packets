//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Exchanges
{
    [PacketHeader("exc_list", Scope.InGame)]
    public class ServerExcListPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public long? Gold { get; set; }

        [PacketIndex(3)]
        public long? BankGold { get; set; }

        [PacketListIndex(4, IsOptional = true)]
        public List<ServerExcListSubPacket?>? SubPackets { get; set; }
    }
}