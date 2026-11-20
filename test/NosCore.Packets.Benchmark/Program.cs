//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.InProcess.Emit;

namespace NosCore.Packets.Benchmark
{
    public static class Program
    {
        // BenchmarkDotNet cannot build a separate process for a runtime it does not know yet, so the benchmarks
        // run in this one.
        public static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args,
            DefaultConfig.Instance.AddJob(Job.Default.WithWarmupCount(3).WithIterationCount(10).WithToolchain(InProcessEmitToolchain.Instance)));
    }
}
