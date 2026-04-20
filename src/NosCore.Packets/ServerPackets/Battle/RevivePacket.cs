//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Battle
{
    // Tells the client a character is coming back after death. Type typically picks
    // which revive flavour to play (0 = basic town respawn, 1 = player respawn with
    // the blue lives counter), VisualId identifies who, and Data carries the
    // context-specific payload (lives remaining for instance raids, 0 otherwise).
    [PacketHeader("revive", Scope.InGame)]
    public class RevivePacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public int Data { get; set; }
    }
}
