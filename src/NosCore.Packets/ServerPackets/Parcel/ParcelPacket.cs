//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Packets.ServerPackets.Movement;

namespace NosCore.Packets.ServerPackets.Parcel
{
    [PacketHeader("parcel", Scope.InGame)]
    public class ParcelPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1)]
        public byte Unknown { get; set; }

        [PacketIndex(2)]
        public short Id { get; set; }

        [PacketIndex(3, IsOptional = true)]
        public ParcelAttachmentSubPacket? ParcelAttachment { get; set; }
    }
}