using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Event
{
    [PacketHeader("evtb", Scope.InGame)]
    public class EventbPacket : PacketBase
    {
        [PacketIndex(0)]
        public short IncreaseChanceUpgradeWeaponArmour { get; set; }

        [PacketIndex(1)]
        public short IncreaseChanceGamblingWeaponArmour { get; set; }

        [PacketIndex(2)]
        public short IncreaseChanceUpgradeSP { get; set; }

        [PacketIndex(3)]
        public short IncreaseChancePerfectionSP { get; set; }

        [PacketIndex(4)]
        public short IncreaseFXPEarned { get; set; }

        [PacketIndex(5)]
        public bool SealedVesselEventIsActive { get; set; }

        [PacketIndex(6)]
        public short IncreaseExperienceEarned { get; set; }

        [PacketIndex(7)]
        public short IncreaseGoldEarned { get; set; }

        [PacketIndex(8)]
        public short IncreaseReputationEarned { get; set; }

        [PacketIndex(9)]
        public short IncreaseItemDropChance { get; set; }

        [PacketIndex(10)]
        public short IncreaseChanceUpgradeRunes { get; set; }

        [PacketIndex(11)]
        public short IncreaseChanceUpgradeTattoos { get; set; }

        [PacketIndex(12)]
        public short IncreaseFishingExperienceGain { get; set; }

        [PacketIndex(13)]
        public short IncreaseCookingExperienceGain { get; set; }

        [PacketIndex(14)]
        public short IncreaseChanceGetSecondRaidBox { get; set; }

        [PacketIndex(15)]
        public short Unknown15 { get; set; }

        [PacketIndex(16)]
        public short Unknown16 { get; set; }

        [PacketIndex(17)]
        public short Unknown17 { get; set; }

        [PacketIndex(18)]
        public short Unknown18 { get; set; }

        [PacketIndex(19)]
        public short Unknown19 { get; set; }

        [PacketIndex(20)]
        public short Unknown20 { get; set; }

        [PacketIndex(21)]
        public short Unknown21 { get; set; }

        [PacketIndex(22)]
        public short Unknown22 { get; set; }

        [PacketIndex(23)]
        public short Unknown23 { get; set; }

        [PacketIndex(24)]
        public short Unknown24 { get; set; }

        [PacketIndex(25)]
        public short Unknown25 { get; set; }

        [PacketIndex(26)]
        public short Unknown26 { get; set; }

        [PacketIndex(27)]
        public short Unknown27 { get; set; }
    }
}
