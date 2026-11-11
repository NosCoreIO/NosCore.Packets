//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Movement
{
    [PacketHeader("walk", Scope.InGame)]
    [MinimumInterval(Milliseconds = 50)]
    public class WalkPacket : PacketBase
    {
        [Range(0, short.MaxValue)]
        [PacketIndex(0)]
        public short XCoordinate { get; set; }

        [Range(0, short.MaxValue)]
        [PacketIndex(1)]
        public short YCoordinate { get; set; }

        [PacketIndex(2)]
        public byte CheckSum { get; set; }

        [PacketIndex(3)]
        public short Speed { get; set; }
    }
}