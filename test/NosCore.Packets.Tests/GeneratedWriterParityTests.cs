//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Generated;
using NosCore.Packets.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class GeneratedWriterParityTests
    {
        private static readonly ISerializer Engine = new Serializer(PacketCorpus.SerializableTypes.ToList());

        [TestMethod]
        public void EveryGeneratedWriterMatchesTheExpressionTree()
        {
            var mismatches = new List<string>();
            int covered = 0, skipped = 0;

            foreach (var type in PacketCorpus.SerializableTypes)
            {
                foreach (var seed in new[] { 1, 7 })
                {
                    IPacket packet;
                    try
                    {
                        packet = PacketCorpus.Build(type, seed);
                    }
                    catch
                    {
                        continue;
                    }

                    if (!PacketWriters.TryWrite(packet, out var generated))
                    {
                        skipped++;
                        continue;
                    }

                    covered++;
                    var expected = Engine.Serialize(packet).TrimEnd();
                    if (!string.Equals(expected, generated.TrimEnd(), StringComparison.Ordinal))
                    {
                        mismatches.Add($"{type.Name}#{seed}\n  tree: {expected}\n  gen : {generated.TrimEnd()}");
                    }
                }
            }

            Console.WriteLine($"COVERED {covered} generated, {skipped} fell back, {mismatches.Count} mismatched");
            foreach (var m in mismatches.Take(15))
            {
                Console.WriteLine(m);
            }

            Assert.AreEqual(0, mismatches.Count, $"{mismatches.Count} of {covered} generated writers disagree");
        }
    }
}
