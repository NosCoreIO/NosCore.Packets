using System;
using System.Collections.Generic;
using System.Text;
using ChickenApi.Packet.Interfaces;
using ChickenApi.Packet.ServerPackets;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChickenApi.Packet.Tests
{
    [TestClass]
    public class SerializationTests
    {
        ISerializer Serializer;
        [TestInitialize]
        public void Setup()
        {
            Serializer = new Serializer(new[] { typeof(NInvPacket), typeof(NInvItemSubPacket) });
        }

        [TestMethod]
        public void GeneratePacketWithNullableOptional()
        {
            var testPacket = new NInvPacket
            {
                Items = new List<NInvItemSubPacket>
                {
                    new NInvItemSubPacket
                    {
                        Type = 0,
                        Slot = 0,
                        Price = 0,
                        RareAmount = null,
                        UpgradeDesign = null,
                        VNum = 0
                    }
                }
            };

            var packet = Serializer.Serialize(testPacket);
            Assert.AreEqual("n_inv 0 0 0 0 0.0.0.-1.0", packet);
        }
    }
}
