//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace NosCore.Packets.Benchmark
{
    // Traces are not part of the repository. NOSCORE_PACKETS_TRACE names a .jsonl of captured server lines
    // ({"l": line, "n": times seen}); without it the server lines are the ones listed here.
    public static class Lines
    {
        private const string TraceVariable = "NOSCORE_PACKETS_TRACE";

        public static readonly string[] Server =
        {
            "in 1 Alice - 104 80 116 2 0 0 0 0 1 -1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1 100 100 0 -1 0 0 0 0 0 0 0 0 -1 - 1 0 0 0 0 1 0 0|0|0 0 0 100 0 0",
            "in 2 1 1 84 118 0 100 100 0 0 0 -1 1 0 -1 - 0 -1 0 0 0 0 0 0 0 0 0 0 0 0 0",
            "in 3 2 100 30 30 0 100 100 0 0 0 -1 0 0 -1 - 0 -1 0 0 0 0 0 0 0 0 0 0 0 0 0",
            "in 9 2024 100009 81 117 5 0 0 0",
            "mv 3 2066 40 52 5",
            "mv 2 1052 101 29 6",
            "st 3 2066 30 100 100 1200 0",
            "su 1 1 3 2066 254 4 11 254 0 0 1 50 532 0 0",
            "cond 1 1 0 0 13",
            "stat 221 221 60 60 0 1024",
            "eff 1 1 5098",
            "c_info Alice - -1 20.915 Clan 126 0 0 0 0 0 1 0 0 0 0 0 0 0 0",
            "n_inv 1 422 0 0 2.0.2024.4.30 2.1.2027.2.700 -1 -1 -1",
            "gidx 1 100 16.915 Clan 1 0|0|0",
            "ghis 0 4|Bob|600|0 6|Bob|30|0",
            "gmbr 0 100|16|Alice|1|1|0|0|1|0 101|16|Bob|1|1|1|0|1|0",
            "qslot 1 1.1.0 1.1.1 1.1.2 1.1.3 1.1.4 1.1.5 1.1.10 1.1.9 1.1.8 1.1.7 1.1.6 7.-1.-1 7.-1.-1 7.-1.-1 1.3.1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 0.1.5 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 0.1.-1",
            "eq 1 0 0 0 0 0 -1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1 0 0 100",
            "guri 2 1 7700921 0",
            "guri 8 8",
            "c_mode 1 14293841 13 10 5 0 100 0",
            "delay 5000 7 #u_i^1^14882169^2^2^4",
            "say 1 1 0 Hello there",
            "out 3 2066",
        };

        public static string[] Trace(Func<string, bool> keep, int count)
        {
            var path = Environment.GetEnvironmentVariable(TraceVariable);
            if (string.IsNullOrEmpty(path) || !File.Exists(path))
            {
                return Server.Where(keep).ToArray();
            }

            var seen = File.ReadLines(path)
                .Select(json => JsonDocument.Parse(json).RootElement)
                .Select(row => (Line: row.GetProperty("l").GetString()!, Times: row.TryGetProperty("n", out var n) ? n.GetInt64() : 1))
                .Where(row => keep(row.Line) && Readable(row.Line))
                .ToList();

            // Drawn by how often each line was seen, so the mix is the one a client reads.
            var random = new Random(42);
            var total = seen.Sum(row => row.Times);
            var picked = new List<string>(count);
            for (var i = 0; i < count && seen.Count > 0; i++)
            {
                var target = random.NextInt64(total);
                foreach (var row in seen)
                {
                    target -= row.Times;
                    if (target < 0)
                    {
                        picked.Add(row.Line);
                        break;
                    }
                }
            }

            return picked.ToArray();
        }

        public static string[] Distinct(Func<string, bool> keep, int count)
        {
            var path = Environment.GetEnvironmentVariable(TraceVariable);
            if (string.IsNullOrEmpty(path) || !File.Exists(path))
            {
                return Server.Where(keep).ToArray();
            }

            var lines = File.ReadLines(path)
                .Select(json => JsonDocument.Parse(json).RootElement.GetProperty("l").GetString()!)
                .Where(line => keep(line) && Readable(line))
                .Distinct(StringComparer.Ordinal)
                .ToList();
            var step = Math.Max(1, lines.Count / count);
            return lines.Where((_, index) => index % step == 0).Take(count).ToArray();
        }

        // Client lines with a keep-alive number in front, as the world server receives them.
        public static readonly string[] Client =
        {
            "1201 walk 40 52 1 11",
            "1202 u_s 0 3 2066",
            "1203 u_s 2 3 2066 40 52",
            "1204 ncif 3 2066",
            "1205 pulse 60 0",
            "1206 say Hello there",
            "1207 guri 4 0 15",
            "1208 npc_req 2 1052",
            "1209 n_run 16 1 1 1052",
            "1210 preq",
            "1211 rest 1 1 1",
            "1212 u_i 1 1 2 2 0",
            "1213 wear 3 0",
            "1214 mvi 2 3 1 5",
            "1215 get 1 1 9001 0",
            "1216 c_close 1",
            "1217 dir 2 1 1",
            "1218 b_i 0 4",
            "1219 gop 1 1",
            "1220 sl 0",
        };

        public static string Header(string line)
        {
            var end = line.IndexOf(' ');
            return end < 0 ? line : line[..end];
        }

        private static bool Readable(string line)
        {
            try
            {
                Engines.ClientSide.Deserialize(line);
                return true;
            }
            catch (ArgumentException)
            {
                return false;
            }
        }
    }
}
