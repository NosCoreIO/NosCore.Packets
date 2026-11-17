//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Inventory
{
    public class IvnSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Slot { get; set; }

        public short VNum { get; set; }

        public bool IsLimited { get; set; }

        [PacketIndex(1)]
        public short WireVNum
        {
            get => LimitedItem.ToWire(VNum, IsLimited);
            set
            {
                VNum = LimitedItem.VNum(value);
                IsLimited = LimitedItem.IsLimited(value);
            }
        }

        [PacketIndex(2)]
        public short RareAmount { get; set; }

        // Main, Etc and Raid items carry one more field after the amount; a mount carries none.
        [PacketIndex(3, IsOptional = true)]
        public short? UpgradeDesign { get; set; } = 0;

        // Specialist cards and costumes stop after this one; equipment carries the last two as well.
        [PacketIndex(4, IsOptional = true)]
        public byte? SecondUpgrade { get; set; } = 0;

        [PacketIndex(5, IsOptional = true)]
        public byte? Unknown5 { get; set; } = 0;

        [PacketIndex(6, IsOptional = true)]
        public short? Unknown6 { get; set; } = 0;
    }
}