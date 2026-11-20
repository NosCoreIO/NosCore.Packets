//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Linq;
using BenchmarkDotNet.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.Benchmark
{
    // Each benchmark reads a set of lines, repeated up to LineCount; the reported time and allocation are per line.
    [MemoryDiagnoser]
    public class DeserializeBenchmarks
    {
        private const int LineCount = 1000;
        private static readonly string[] SharedHeaders = { "guri", "score", "e_info" };

        private string[] _traffic = null!;
        private string[] _distinct = null!;
        private string[] _shared = null!;
        private string[] _client = null!;

        [GlobalSetup]
        public void Setup()
        {
            _traffic = Repeat(Lines.Trace(_ => true, LineCount));
            _distinct = Repeat(Lines.Distinct(_ => true, LineCount));
            _shared = Repeat(Lines.Distinct(IsShared, 300) is { Length: > 0 } traced ? traced : Lines.Server.Where(IsShared).ToArray());
            _client = Repeat(Lines.Client);
        }

        [Benchmark(OperationsPerInvoke = LineCount, Description = "server lines, as seen in traffic")]
        public IPacket? ServerTraffic() => ReadAll(Engines.ClientSide, _traffic);

        [Benchmark(OperationsPerInvoke = LineCount, Description = "server lines, one of each")]
        public IPacket? ServerDistinct() => ReadAll(Engines.ClientSide, _distinct);

        [Benchmark(OperationsPerInvoke = LineCount, Description = "shared headers (guri, score, e_info)")]
        public IPacket? Shared() => ReadAll(Engines.ClientSide, _shared);

        [Benchmark(OperationsPerInvoke = LineCount, Description = "client lines")]
        public IPacket? Client() => ReadAll(Engines.ServerSide, _client);

        private static bool IsShared(string line) => System.Array.IndexOf(SharedHeaders, Lines.Header(line)) >= 0;

        private static string[] Repeat(string[] lines) =>
            Enumerable.Range(0, LineCount).Select(index => lines[index % lines.Length]).ToArray();

        private static IPacket? ReadAll(IDeserializer reader, string[] lines)
        {
            IPacket? last = null;
            foreach (var line in lines)
            {
                last = reader.Deserialize(line);
            }

            return last;
        }
    }
}
