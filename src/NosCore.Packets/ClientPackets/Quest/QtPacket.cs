﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Quest
{
    [PacketHeader("qt", Scope.InGame | Scope.InExchange)]
    public class QtPacket : PacketBase
    {
        [PacketIndex(0)]
        public QuestActionType Type { get; set; }

        [PacketIndex(1)]
        public int Data { get; set; }
    }
}