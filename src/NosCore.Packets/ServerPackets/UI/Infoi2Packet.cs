//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.UI
{
    [PacketHeader("infoi2", Scope.InGame)]
    public class Infoi2Packet : PacketBase
    {
        [PacketIndex(0)]
        public Game18NConstString Message { get; set; }

        [PacketIndex(1)]
        public byte ArgumentType { get; set; }
        
        [PacketIndex(2)]
        public Game18NArguments Game18NArguments { get; set; } = new(1);
    }
}
