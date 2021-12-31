//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Mates
{
    [PacketHeader("ib", Scope.InGame)]
    public class IbPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Unknown1 { get; set; }

        [PacketIndex(1)]
        public byte Unknown2 { get; set; }
    }
}