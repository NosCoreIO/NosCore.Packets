﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Player
{
    [PacketHeader("levelup", Scope.InGame)]
    public class LevelUpPacket : PacketBase
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }
    }
}