//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NosCore.Packets.ClientPackets.Player
{
    [PacketHeader("bpm", Scope.InGame)]
    public class BpmPacket : PacketBase
    {
        public BpmPacket(List<BpmSubTypePacket> questList)
        {
            QuestList = questList;
        }

        [PacketIndex(0)]
        public byte Unknow { get; set; } = 70; // todo : to find

        [PacketIndex(1)]
        public bool IsBattlePassEnabled { get; set; }

        [PacketIndex(2)]
        public int MaxBattlePassPoints { get; set; }

        [PacketIndex(3)]
        public int Unknow2 { get; set; } = 21093011; // todo : to find

        [PacketIndex(4)]
        public int Unknow3 { get; set; } = 21111111; // todo : to find
        
        [PacketListIndex(5, SpecialSeparator = " ")]
        public List<BpmSubTypePacket> QuestList { get; set; }
    }
}