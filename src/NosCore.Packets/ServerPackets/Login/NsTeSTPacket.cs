//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using System.Linq;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Login
{
    [PacketHeader("NsTeST", Scope.OnLoginScreen)]
    public class NsTestPacket : PacketBase
    {
        [PacketIndex(0)]
        public RegionType RegionType { get; set; }

        [PacketIndex(1)]
        public string? AccountName { get; set; }

        //this seems to be always 2 in case of new auth and null else
        [PacketIndex(2, IsOptional = true)]
        public int? Unknown { get; set; } = 2;

        //0-5 English / International
        //6-11 German
        //12-17 French
        //18-23 Italian
        //24-29 Polish
        //30-35 Spanish
        [PacketListIndex(3, Length = 60, SpecialSeparator = " ")]
        public List<WorldCharacterCount> ServerCharacters { get; set; } =
            Enumerable.Repeat(0, 60).Select(_ => new WorldCharacterCount()).ToList();

        [PacketIndex(4)]
        public int SessionId { get; set; }


        [PacketListIndex(5)]
        public List<NsTeStSubPacket?>? SubPacket { get; set; }
    }
}