//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Movement
{
    [PacketHeader("pulse")]
    public class PulsePacket : PacketBase
    {
        [PacketIndex(0)]
        public int Tick { get; set; }
    }
}