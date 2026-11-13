//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Mates
{
    // Shows or hides the NosMate panel's pet basket or partner backpack button.
    [PacketHeader("ib", Scope.InGame)]
    public class IbPacket : PacketBase
    {
        [PacketIndex(0)]
        public CarriedStorageType Storage { get; set; }

        [PacketIndex(1)]
        public bool IsAvailable { get; set; }
    }
}
