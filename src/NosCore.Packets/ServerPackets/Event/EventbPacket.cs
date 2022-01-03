using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Event
{
    [PacketHeader("evtb", Scope.InGame)]
    public class EventbPacket
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

        [PacketIndex(5)]
        public short IncreaseExperienceEarned { get; set; }

        [PacketIndex(5)]
        public short IncreaseGoldEarned { get; set; }

        [PacketIndex(6)]
        public short IncreaseReputationEarned { get; set; }

        [PacketIndex(7)]
        public short IncreaseItemDropChance { get; set; }

        [PacketIndex(8)]
        public short IncreaseChanceUpgradeRunes { get; set; }

        [PacketIndex(9)]
        public short IncreaseChanceUpgradeTattoos { get; set; }

        [PacketIndex(10)]
        public short IncreaseFishingExperienceGain { get; set; }

        [PacketIndex(11)]
        public short IncreaseCookingExperienceGain { get; set; }

        [PacketIndex(12)]
        public short IncreaseChanceGetSecondRaidBox { get; set; }
    }
}
