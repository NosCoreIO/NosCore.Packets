//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Event
{
    // The raid's start and end banners: one when the team enters the raid, one when its boss falls.
    [PacketHeader("raidbf", Scope.InGame)]
    public class RaidbfPacket : PacketBase
    {
        // 0 in every trace.
        [PacketIndex(0)]
        public byte Flag { get; set; }

        [PacketIndex(1)]
        public RaidBannerType Type { get; set; }

        // Fixed for a raid and the same as raidmbf's last field: 25 in the Mother Cuby raid, 20 in Zenas'.
        [PacketIndex(2)]
        public byte Unknown { get; set; }
    }
}
