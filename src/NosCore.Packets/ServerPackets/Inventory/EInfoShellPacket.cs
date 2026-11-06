//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
//

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Inventory
{
    // Answer to eqinfo for a shell. The client reads the options of a weapon shell with the
    // weapon option names and those of an armour shell with the armour ones.
    [PacketHeader("e_info", Scope.InGame, AllowDuplicateHeader = true)]
    public class EInfoShellPacket : PacketBase
    {
        [PacketIndex(0)]
        public EInfoPacketType Type { get; set; } = EInfoPacketType.Shell;

        [PacketIndex(1)]
        public short ItemVNum { get; set; }

        [PacketIndex(2)]
        public byte Level { get; set; }

        [PacketIndex(3)]
        public short Rare { get; set; }

        [PacketIndex(4)]
        public long Price { get; set; }

        [PacketIndex(5)]
        public byte ShellOptionCount { get; set; }

        [PacketListIndex(6, IsOptional = true)]
        public List<EInfoShellOptionSubPacket>? ShellOptions { get; set; }
    }
}
