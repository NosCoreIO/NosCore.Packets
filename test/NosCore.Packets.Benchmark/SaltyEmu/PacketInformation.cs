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