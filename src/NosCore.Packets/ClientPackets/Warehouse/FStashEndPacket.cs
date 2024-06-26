﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Warehouse
{
    [PacketHeader("f_stash_end", Scope.InGame | Scope.InTrade | Scope.OnCharacterScreen)]
    public class FStashEndPacket : PacketBase
    {
    }
}