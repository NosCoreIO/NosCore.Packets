//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.CharacterSelectionScreen
{
    [PacketHeader("clist", Scope.OnCharacterScreen)]
    public class ClistPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Slot { get; set; }

        [PacketIndex(1)]
        public string? Name { get; set; }

        [PacketIndex(2)]
        public byte Unknown { get; set; } //TODO to find

        [PacketIndex(3)]
        public GenderType Gender { get; set; }

        [PacketIndex(4)]
        public HairStyleType HairStyle { get; set; }

        [PacketIndex(5)]
        public HairColorType HairColor { get; set; }

        [PacketIndex(6)]
        public byte Unknown1 { get; set; } //TODO to find

        [PacketIndex(7)]
        public CharacterClassType Class { get; set; }

        [PacketIndex(8)]
        public byte Level { get; set; }

        [PacketIndex(9)]
        public byte HeroLevel { get; set; }

        [PacketListIndex(10)]
        public List<short?>? Equipments { get; set; }//TODO define this

        [PacketIndex(11)]
        public byte JobLevel { get; set; }

        [PacketIndex(12)] 
        public string? ExtraSpace { get; set; } = string.Empty;

        [PacketIndex(13)]
        public byte QuestCompletion { get; set; }

        [PacketIndex(14)]
        public byte QuestPart { get; set; }

        [PacketListIndex(15)]
        public List<short?>? Pets { get; set; }

        [PacketIndex(16)]
        public int Design { get; set; }

        [PacketIndex(17)]
        public bool Rename { get; set; }
    }
}