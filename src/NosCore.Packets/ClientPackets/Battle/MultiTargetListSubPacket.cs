﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Battle
{
    [PacketHeader("multi_target_list_sub_packet")]
    public class MultiTargetListSubPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public int SkillCastId { get; set; }

        [PacketIndex(1)]
        public int TargetId { get; set; }
    }
}