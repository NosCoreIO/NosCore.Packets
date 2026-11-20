//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.UI
{
    // What a teleport stone's delay asks the client to send back once its bar is full: the cell the
    // character is then moved to, and the stone it talked to.
    [PacketHeader("guri", Scope.InGame, AllowDuplicateHeader = true)]
    public class GuriMapTeleporterPacket : PacketBase
    {
        [PacketIndex(0)]
        public GuriPacketType Type { get; set; } = GuriPacketType.MapTeleporter;

        [PacketIndex(1)]
        public short DestinationX { get; set; }

        [PacketIndex(2)]
        public short DestinationY { get; set; }

        [PacketIndex(3)]
        public long NpcId { get; set; }
    }
}
