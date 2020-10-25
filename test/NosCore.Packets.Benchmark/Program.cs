//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using NosCore.Packets.Benchmark.SaltyEmu;
using NosCore.Packets.ClientPackets.Relations;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Packets.ServerPackets.Shop;
using NosCore.Packets.ServerPackets.UI;

namespace NosCore.Packets.Benchmark
{
    [SimpleJob(RuntimeMoniker.CoreRt31)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [RPlotExporter, RankColumn]
    [MemoryDiagnoser]
    public class PacketSerializationSpeed
    {
        readonly ISerializer _chickenApiSerializer = new Serializer(
            new[]
            {
                typeof(NInvPacket),
            });

        readonly PluggablePacketFactory _saltyEmuPacketSerializer = new PluggablePacketFactory();

        [Params(1, 10, 100)] public int NumberOfItems;

        private IPacket? _testPacket;

        [GlobalSetup]
        public void Setup()
        {
            _testPacket = new DlgPacket
            {
                Question = "question",
                NoPacket = new FinsPacket { Type = FinsPacketType.Rejected, CharacterId = 1 },
                YesPacket = new FinsPacket { Type = FinsPacketType.Accepted, CharacterId = 1 }
            };
        }

        [Benchmark(Description = "NosCore.Packets' Serializer (Expression tree)")]
        public bool ChickenAPI_Serializer_Serialize_X_Packets()
        {
            for (var i = 0; i < NumberOfItems; i++)
            {
                _chickenApiSerializer.Serialize(_testPacket!);
            }

            return true;
        }

        [Benchmark(Description = "SaltyEmu's Packet Factory, forked from OpenNos")]
        public bool SaltyEmu_Serializer_Serialize_X_Packets()
        {
            for (var i = 0; i < NumberOfItems; i++)
            {
                _saltyEmuPacketSerializer.Serialize(_testPacket!);
            }

            return true;
        }
    }

    class Program
    {
        static void Main()
        {
            BenchmarkRunner.Run<PacketSerializationSpeed>();
        }
    }
}