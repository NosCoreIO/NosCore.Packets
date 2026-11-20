//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Inventory
{
    [PacketHeader("ivn", Scope.InGame)]
    public class IvnPacket : PacketBase
    {
        [PacketIndex(0)]
        public PocketType Type { get; set; }

        // A mount or raid pocket line has an empty field before its item.
        [PacketIndex(1, IsOptional = true)]
        [PacketPresentWhen(nameof(Type), PocketType.Mount, PocketType.Raid)]
        public string? ExtraSpace => Type is PocketType.Mount or PocketType.Raid ? string.Empty : null;

        [PacketListIndex(2)]
        public List<IvnSubPacket>? IvnSubPackets { get; set; }
    }
}