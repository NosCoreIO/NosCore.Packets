using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using ChickenAPI.Packets.Benchmark.SaltyEmu;
using ChickenAPI.Packets.ClientPackets;
using ChickenAPI.Packets.ClientPackets.Relations;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;
using ChickenAPI.Packets.ServerPackets;
using ChickenAPI.Packets.ServerPackets.Shop;
using ChickenAPI.Packets.ServerPackets.UI;

namespace ChickenAPI.Packets.Benchmark
{
    [CoreJob, CoreRtJob]
    [RPlotExporter, RankColumn]
    [MemoryDiagnoser]
    public class PacketSerializationSpeed
    {
        readonly ISerializer ChickenAPISerializer = new Serializer(
            new[]
            {
                typeof(NInvPacket),
            });

        readonly PluggablePacketFactory SaltyEmuPacketSerializer = new PluggablePacketFactory();

        [Params(1, 10, 100)] public int NumberOfItems;

        private IPacket _testPacket;

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

        [Benchmark(Description = "ChickenAPI.Packets' Serializer (Expression tree)")]
        public bool ChickenAPI_Serializer_Serialize_X_Packets()
        {
            for (int i = 0; i < NumberOfItems; i++)
            {
                ChickenAPISerializer.Serialize(_testPacket);
            }

            return true;
        }

        [Benchmark(Description = "SaltyEmu's Packet Factory, forked from OpenNos")]
        public bool SaltyEmu_Serializer_Serialize_X_Packets()
        {
            for (int i = 0; i < NumberOfItems; i++)
            {
                SaltyEmuPacketSerializer.Serialize(_testPacket);
            }

            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Summary summary = BenchmarkRunner.Run<PacketSerializationSpeed>();
        }
    }
}