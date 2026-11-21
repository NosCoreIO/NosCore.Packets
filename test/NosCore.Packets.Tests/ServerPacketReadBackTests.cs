//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NosCore.Packets.Tests
{
    // A client, or a test standing in for one, reads the server's packets with the same classes
    // the server writes them with, so every server packet has to come back as it went out.
    [TestClass]
    public class ServerPacketReadBackTests
    {
        private static readonly ISerializer Engine = new Serializer(PacketCorpus.SerializableTypes.ToList());

        private static readonly IDeserializer ClientSide = new Deserializer(PacketCorpus.SerializableTypes
            .Where(t => IsServerPacket(t) || !ServerHeaders.Contains(t.GetCustomAttribute<PacketHeaderAttribute>()?.Identification ?? string.Empty)));

        private static HashSet<string> ServerHeaders => PacketCorpus.PacketTypes.Where(IsServerPacket)
            .Select(t => t.GetCustomAttribute<PacketHeaderAttribute>()!.Identification).ToHashSet();

        // Packets the line alone cannot bring back. Remove an entry once it reads back; never add one to get green.
        private static readonly Dictionary<string, string> Unreadable = new()
        {
            ["SayItemPacket"] = "carries an e_info",
            ["RcbListPacket"] = "carries an e_info",
            ["RcsListPacket"] = "carries an e_info",
        };

        private static bool IsServerPacket(Type type) => type.Namespace?.Contains(".ServerPackets", StringComparison.Ordinal) == true;

        [TestMethod]
        public void EveryServerPacketReadsBackAsItWasWritten()
        {
            var failures = new List<string>();
            foreach (var type in PacketCorpus.PacketTypes.Where(IsServerPacket).Where(type => !Unreadable.ContainsKey(type.Name)))
            {
                foreach (var seed in new[] { 1, 7 })
                {
                    var line = Engine.Serialize(PacketCorpus.Build(type, seed));
                    try
                    {
                        var read = ClientSide.Deserialize(line);
                        var again = Engine.Serialize(read);
                        if (read.GetType() != type || again != line)
                        {
                            failures.Add($"{type.Name}#{seed}: {line}  =>  {read.GetType().Name}: {again}");
                        }
                    }
                    catch (Exception ex)
                    {
                        failures.Add($"{type.Name}#{seed}: {line}  =>  {ex.InnerException?.Message ?? ex.Message}");
                    }
                }
            }

            Assert.AreEqual(0, failures.Count, string.Join(Environment.NewLine, failures));
        }

        [TestMethod]
        [DataRow("in 1 Alice - 104 80 116 2 0 0 0 0 1 -1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1 100 100 0 -1 0 0 0 0 0 0 0 0 -1 - 1 0 0 0 0 1 0 0|0|0 0 0 100 0 0")]
        [DataRow("in 2 1 1 84 118 0 100 100 0 0 0 -1 1 0 -1 - 0 -1 0 0 0 0 0 0 0 0 0 0 0 0 0")]
        [DataRow("in 3 2 100 30 30 0 100 100 0 0 0 -1 0 0 -1 - 0 -1 0 0 0 0 0 0 0 0 0 0 0 0 0")]
        [DataRow("in 9 2024 100009 81 117 5 0 0 0")]
        [DataRow("n_inv 1 422 0 0 2.0.2024.4.30 2.1.2027.2.700 -1 -1 -1")]
        [DataRow("c_info Alice - -1 20.915 Clan 126 0 0 0 0 0 1 0 0 0 0 0 0 0 0")]
        [DataRow("gidx 1 100 16.915 Clan 1 0|0|0")]
        [DataRow("ghis 0 4|Bob|600|0 6|Bob|30|0")]
        [DataRow("gmbr 0 100|16|Alice|1|1|0|0|1|0 101|16|Bob|1|1|1|0|1|0")]
        [DataRow("post 1 1 0 0 0 2611150101 Alice Lunch")]
        [DataRow("eq 1 0 0 0 0 0 -1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1 0 0 100")]
        [DataRow("NsTeST  0 alice1 2 1 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 2 127.0.0.1:4000:1:0.1.S1-NosCore -1:-1:-1:10000.10000.1")]
        [DataRow("NsTeST  0 alice1 2 2 1 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 2 127.0.0.1:4000:1:0.1.S1-NosCore -1:-1:-1:10000.10000.1")]
        public void ALineTheServerWritesReadsBack(string line)
        {
            Assert.AreEqual(line, Engine.Serialize(ClientSide.Deserialize(line)));
        }

        [TestMethod]
        public void AnInPacketReadsTheFieldsOfItsKindOfEntity()
        {
            var item = (ServerPackets.Visibility.InPacket)ClientSide.Deserialize("in 9 2024 100009 81 117 5 0 0 0");
            var npc = (ServerPackets.Visibility.InPacket)ClientSide.Deserialize("in 2 1 1 84 118 0 100 100 0 0 0 -1 1 0 -1 - 0 -1 0 0 0 0 0 0 0 0 0 0 0 0 0");

            Assert.AreEqual((5, (string?)null, (byte?)null), (item.InItemSubPacket?.Amount, item.Name, item.Direction));
            Assert.AreEqual((100, (object?)null), (npc.InNonPlayerSubPacket?.InAliveSubPacket?.Hp, (object?)npc.InCharacterSubPacket));
        }

        [TestMethod]
        public void AShopListStopsAtItsLastItem()
        {
            var shop = (ServerPackets.Shop.NInvPacket)ClientSide.Deserialize("n_inv 1 422 0 0 2.0.2024.4.30 2.1.2027.2.700 -1");

            Assert.AreEqual(3, shop.Items?.Count);
            Assert.AreEqual((2027, (short?)2, 700), (shop.Items![1]!.VNum, shop.Items[1]!.RareAmount, shop.Items[1]!.Price));
        }

        [TestMethod]
        public void ASkillShopListReadsItsSkills()
        {
            var shop = (ServerPackets.Shop.NInvPacket)ClientSide.Deserialize("n_inv 2 7143 0 1 242 258 340");

            Assert.AreEqual((byte?)1, shop.ShopKind);
            CollectionAssert.AreEqual(new short[] { 242, 258, 340 }, shop.Skills);
            Assert.IsNull(shop.Items);
            Assert.IsNull(shop.FamilySkills);
        }

        [TestMethod]
        public void TheProductionListsAreToldApartByTheirType()
        {
            var made = (ServerPackets.Production.MlistPacket)ClientSide.Deserialize("m_list 2 1012 1013 -100");
            var materials = (ServerPackets.Production.MlistMaterialsPacket)ClientSide.Deserialize("m_list 3 1 1012 2 1013 5 -1");

            CollectionAssert.AreEqual(new short[] { 1012, 1013 }, made.ItemVNums);
            Assert.AreEqual((short)1, materials.Amount);
            CollectionAssert.AreEqual(new[] { (1012, 2), (1013, 5) },
                materials.Materials.Select(m => ((int)m.VNum, (int)m.Amount)).ToList());
        }

        [TestMethod]
        public void EveryUnreadablePacketStillFails()
        {
            var readable = PacketCorpus.PacketTypes.Where(type => Unreadable.ContainsKey(type.Name)).Where(type =>
            {
                var line = Engine.Serialize(PacketCorpus.Build(type, 1));
                try
                {
                    var read = ClientSide.Deserialize(line);
                    return read.GetType() == type && Engine.Serialize(read) == line;
                }
                catch (ArgumentException)
                {
                    return false;
                }
            }).Select(type => type.Name).ToList();

            Assert.AreEqual(0, readable.Count, $"These read back now; take them off the list: {string.Join(", ", readable)}");
        }
    }
}
