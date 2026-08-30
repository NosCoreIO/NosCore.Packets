//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerifyMSTest;
using VerifyTests;

namespace NosCore.Packets.Tests
{
    // Pins the wire output of every headered packet in the assembly, so the swap from
    // the expression-tree serializer to generated code can be proven byte-identical
    // rather than argued about. The approved snapshot IS the specification: if a
    // generator change alters any of these lines, this test says exactly which.
    [TestClass]
    public class SerializerCorpusTests : VerifyBase
    {
        private static readonly ISerializer Engine = new Serializer(PacketCorpus.SerializableTypes.ToList());

        [TestMethod]
        public Task ExpressionTreeSerializerOutputIsPinnedForEveryPacket()
        {
            var sb = new StringBuilder();

            foreach (var line in Corpus())
            {
                sb.AppendLine(line);
            }

            // Pinned explicitly: DocumentationTest points Verify at another directory,
            // so without this the snapshot resolves to a different path depending on
            // which test ran first.
            var settings = new VerifySettings();
            settings.UseDirectory(SnapshotDirectory);
            return Verify(sb.ToString(), settings);
        }

        private static string SnapshotDirectory => Path.Combine(
            Directory.GetCurrentDirectory(), "..", "..", "..");

        // Serializer keys _packetSerializerDictionary by typeof(T).Name - the SIMPLE
        // name - so two packets sharing a class name across namespaces overwrite each
        // other, and Initialize resolves the clash by letting the non-ClientPackets one
        // win. Serializing the loser then invokes the winner's delegate and throws
        // ArgumentException. Each server currently registers a filtered subset of packet
        // types, which is why this has not bitten in production.
        //
        // Pinned rather than fixed here: generated per-type methods cannot collide by
        // simple name, so porting to the generator removes the failure mode outright.
        private static readonly string[] KnownSimpleNameCollisions =
        {
            "BpmPacket", "DropPacket", "FamilyDismissPacket", "GidxPacket", "GuriPacket",
            "MallPacket", "NpInfoPacket", "RsfiPacket", "ShopClosePacket", "UseObjPacket"
        };

        [TestMethod]
        public void OnlyTheKnownSimpleNameCollisionsFailToSerialize()
        {
            var failures = new List<string>();

            foreach (var type in PacketCorpus.PacketTypes)
            {
                try
                {
                    Engine.Serialize(PacketCorpus.Build(type, seed: 1));
                }
                catch (Exception ex)
                {
                    failures.Add($"{type.Name}: {ex.GetType().Name} {ex.Message}");
                }
            }

            var unexpected = failures
                .Where(f => !KnownSimpleNameCollisions.Any(known =>
                    f.StartsWith(known + ":", StringComparison.Ordinal)))
                .ToList();

            Assert.AreEqual(0, unexpected.Count,
                $"{unexpected.Count} packets threw for a reason other than the known name " +
                $"collisions:{Environment.NewLine}{string.Join(Environment.NewLine, unexpected)}");
        }

        [TestMethod]
        public void CollidingPacketNamesAreStillDistinctTypes()
        {
            var collisions = PacketCorpus.PacketTypes
                .GroupBy(t => t.Name)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key)
                .OrderBy(n => n, StringComparer.Ordinal)
                .ToList();

            CollectionAssert.AreEqual(
                KnownSimpleNameCollisions.OrderBy(n => n, StringComparer.Ordinal).ToList(),
                collisions,
                $"packet simple-name collisions changed:{Environment.NewLine}{string.Join(Environment.NewLine, collisions)}");
        }

        // Two seeds per packet: one exercises the populated path, the other shifts every
        // value so an off-by-one in separator or optional-run handling cannot hide behind
        // a coincidence.
        private static IEnumerable<string> Corpus()
        {
            foreach (var type in PacketCorpus.PacketTypes)
            {
                foreach (var seed in new[] { 1, 7 })
                {
                    string result;
                    try
                    {
                        result = Engine.Serialize(PacketCorpus.Build(type, seed));
                    }
                    catch (Exception ex)
                    {
                        result = $"<<THREW {ex.GetType().Name}>>";
                    }

                    yield return $"{type.Name}#{seed} => {result}";
                }
            }
        }
    }
}
