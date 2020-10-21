//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Player
{
    [PacketHeader("rsfi", Scope.InGame)]
    public class RsfiPacket : PacketBase
    {
        //TODO make this real packet, it's just here to fix a dialog issue with client
        [PacketIndex(0)]
        public byte Act { get; set; }

        [PacketIndex(1)]
        public byte ActPart { get; set; }

        [PacketIndex(2)]
        public byte Unknown1 { get; set; }

        [PacketIndex(3)]
        public byte Unknown2 { get; set; }

        [PacketIndex(4)]
        public byte Ts { get; set; }

        [PacketIndex(5)]
        public byte TsMax { get; set; }
    }
}