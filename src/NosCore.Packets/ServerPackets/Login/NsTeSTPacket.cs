//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using System.Linq;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Login
{
    [PacketHeader("NsTeST", Scope.OnLoginScreen)]
    public class NsTestPacket : PacketBase
    {
        [PacketIndex(0)]
        public string LeadingBlank { get; set; } = string.Empty;

        [PacketIndex(1)]
        public RegionType RegionType { get; set; }

        [PacketIndex(2)]
        public string? AccountName { get; set; }

        [PacketIndex(3, IsOptional = true)]
        public int? Unknown { get; set; } = 2;

        [PacketIndex(4)] public int Unknown2 { get; set; }
        [PacketIndex(5)] public int Unknown3 { get; set; }
        [PacketIndex(6)] public int Unknown4 { get; set; }
        [PacketIndex(7)] public int Unknown5 { get; set; }
        [PacketIndex(8)] public int Unknown6 { get; set; }
        [PacketIndex(9)] public int Unknown7 { get; set; }

        //0-5 English / International
        //6-11 German
        //12-17 French
        //18-23 Italian
        //24-29 Polish
        //30-35 Spanish
        [PacketListIndex(10, Length = 60, SpecialSeparator = " ")]
        public List<WorldCharacterCount> ServerCharacters { get; set; } =
            Enumerable.Repeat(0, 60).Select(_ => new WorldCharacterCount()).ToList();

        [PacketIndex(11)]
        public int SessionId { get; set; }


        [PacketListIndex(12)]
        public List<NsTeStSubPacket?>? SubPacket { get; set; }
    }
}
