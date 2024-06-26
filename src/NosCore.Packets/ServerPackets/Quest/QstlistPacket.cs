﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Quest
{

    [PacketHeader("qstlist", Scope.InGame)]
    public class QstlistPacket : PacketBase
    {
        public QstlistPacket(List<QuestSubPacket> questSubPackets)
        {
            QuestSubPackets = questSubPackets;
        }

        [PacketListIndex(0, RemoveHeader = true)]
        public List<QuestSubPacket> QuestSubPackets { get; set; }
    }
}