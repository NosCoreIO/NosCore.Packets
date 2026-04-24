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
        public RegionType RegionType { get; set; }

        [PacketIndex(1)]
        public string? AccountName { get; set; }

        //this seems to be always 2 in case of new auth and null else
        [PacketIndex(2, IsOptional = true)]
        public int? Unknown { get; set; } = 2;

        // The six fields below were introduced in a newer client revision; their
        // semantics aren't reverse-engineered yet. Observed wires start with
        // `1 0 11 4 13 3` at this offset before the -99/0 character-count pairs.
        [PacketIndex(3)] public int Unknown2 { get; set; }
        [PacketIndex(4)] public int Unknown3 { get; set; }
        [PacketIndex(5)] public int Unknown4 { get; set; }
        [PacketIndex(6)] public int Unknown5 { get; set; }
        [PacketIndex(7)] public int Unknown6 { get; set; }
        [PacketIndex(8)] public int Unknown7 { get; set; }

        //0-5 English / International
        //6-11 German
        //12-17 French
        //18-23 Italian
        //24-29 Polish
        //30-35 Spanish
        [PacketListIndex(9, Length = 60, SpecialSeparator = " ")]
        public List<WorldCharacterCount> ServerCharacters { get; set; } =
            Enumerable.Repeat(0, 60).Select(_ => new WorldCharacterCount()).ToList();

        [PacketIndex(10)]
        public int SessionId { get; set; }


        [PacketListIndex(11)]
        public List<NsTeStSubPacket?>? SubPacket { get; set; }
    }
}