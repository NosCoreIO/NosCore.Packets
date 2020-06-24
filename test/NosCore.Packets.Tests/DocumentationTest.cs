//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using ApprovalTests;
using ApprovalTests.Writers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class DocumentationTest
    {
        private static IEnumerable<IGrouping<string, Type>> GetPacketsWithinNamespace(string name)
        {
            return typeof(UnresolvedPacket).Assembly.GetTypes()
                .Where(s => s.GetInterfaces().Any(p => p == typeof(IPacket)))
                .Where(s => !s.IsAbstract)
                .Where(s => s.Namespace?.Contains(name) ?? true)
                .GroupBy(s => s.Namespace!.Substring(s.Namespace.LastIndexOf('.') + 1))
                .OrderBy(s => s.Key);
        }

        private static IEnumerable<Type> GetPackets(IEnumerable<Type> types)
        {
            return types.Where(s => s.GetCustomAttribute<PacketHeaderAttribute>() != null)
                .OrderBy(s => s.Name);
        }

        [TestMethod]
        public void PacketsDocumentation()
        {
            var builder = new StringBuilder();
            builder.AppendLine("# NosCore.Packets's Documentation");
            builder.AppendLine("## ClientPackets :");
            foreach (IGrouping<string, Type> packetGroup in GetPacketsWithinNamespace("ClientPackets"))
            {
                builder.AppendLine();
                builder.AppendLine($"### {packetGroup.Key}");
                foreach (Type packet in GetPackets(packetGroup))
                {
                    builder.AppendLine($"- [{packet.GetCustomAttribute<PacketHeaderAttribute>()!.Identification}](src/NosCore.Packets/ClientPackets/{packetGroup.Key}/{packet}.cs)");
                }
            }

            builder.AppendLine();
            builder.AppendLine("## ServerPackets :");
            foreach (IGrouping<string, Type> packetGroup in GetPacketsWithinNamespace("ServerPackets"))
            {
                builder.AppendLine();
                builder.AppendLine($"### {packetGroup.Key}");
                foreach (Type packet in GetPackets(packetGroup))
                {
                    builder.AppendLine($"- [{packet.GetCustomAttribute<PacketHeaderAttribute>()!.Identification}](src/NosCore.Packets/ServerPackets/{packetGroup.Key}/{packet}.cs)");
                }
            }

            Approvals.Verify(WriterFactory.CreateTextWriter(builder.ToString(), "md"));
        }
    }
}
