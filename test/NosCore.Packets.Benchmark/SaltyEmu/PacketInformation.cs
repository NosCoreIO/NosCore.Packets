//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;

namespace NosCore.Packets.Benchmark.SaltyEmu
{
    public class PacketInformation
    {
        public string? Header { get; set; }
        public Type? Type { get; set; }

        public PacketPropertyContainer[]? PacketProps { get; set; }
    }
}