//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.Benchmark
{
    // One packet at a time, read from its line and written back to it.
    [MemoryDiagnoser]
    public class LineBenchmarks
    {
        private static readonly Dictionary<string, string> Samples = new()
        {
            ["in 1"] = "in 1 Alice - 104 80 116 2 0 0 0 0 1 -1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1 100 100 0 -1 0 0 0 0 0 0 0 0 -1 - 1 0 0 0 0 1 0 0|0|0 0 0 100 0 0",
            ["in 3"] = "in 3 2 100 30 30 0 100 100 0 0 0 -1 0 0 -1 - 0 -1 0 0 0 0 0 0 0 0 0 0 0 0 0",
            ["mv"] = "mv 3 2066 40 52 5",
            ["st"] = "st 2 1315219 91 0 100 100 40513 1950 40513 1950 0",
            ["su"] = "su 2 1497894 2 1497894 1300 280 23 4039 0 0 1 100 0 -2 0 30366 30366",
            ["c_info"] = "c_info Alice - -1 20.915 Clan 126 0 0 0 0 0 1 0 0 0 0 0 0 0 0",
            ["inv"] = "inv 0 0.12.0.0.0.0.0 1.1.0.0.0.0.0 2.13.2.0.0.0.0 3.2.2.0.0.0.0 4.200.0.0.0.0.0 5.3.0.1.0.0.0 6.501.0.0.0.0.0 7.10.1.0.0.0.0",
            ["qslot"] = "qslot 1 1.1.0 1.1.1 1.1.2 1.1.3 1.1.4 1.1.5 1.1.10 1.1.9 1.1.8 1.1.7 1.1.6 7.-1.-1 7.-1.-1 7.-1.-1 1.3.1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 0.1.5 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 0.1.-1",
            ["gmbr"] = "gmbr 0 100|16|Alice|1|1|0|0|1|0 101|16|Bob|1|1|1|0|1|0",
            ["guri"] = "guri 2 1 7700921 0",
            ["score"] = "score 1 0 0 0 0 0 0 0 0 0",
            ["e_info"] = "e_info 3 241 20 0 0 0 0 0 0 0 0 2400 0 0 -1",
        };

        private string _line = null!;
        private IPacket _packet = null!;

        [Params("in 1", "in 3", "mv", "st", "su", "c_info", "inv", "qslot", "gmbr", "guri", "score", "e_info")]
        public string Packet { get; set; } = null!;

        [GlobalSetup]
        public void Setup()
        {
            _line = Samples[Packet];
            _packet = Engines.ClientSide.Deserialize(_line);
        }

        [Benchmark]
        public IPacket Read() => Engines.ClientSide.Deserialize(_line);

        [Benchmark]
        public string Write() => Engines.Serializer.Serialize(_packet);
    }
}
