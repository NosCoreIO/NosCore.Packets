﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Login
{
    [PacketHeader("failc", Scope.OnLoginScreen)]
    public class FailcPacket : PacketBase
    {
        [PacketIndex(0)]
        public LoginFailType Type { get; set; }
    }
}