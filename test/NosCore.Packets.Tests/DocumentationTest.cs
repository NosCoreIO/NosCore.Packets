//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ApprovalTests;
using ApprovalTests.Writers;
using Microsoft.Extensions.Http;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestPlatform.Common.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.ParserInputGenerator.Downloader;
using NosCore.ParserInputGenerator.Extractor;

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

        [TestMethod]
        public async Task I18NDocumentation()
        {
            var extractor = new Extractor(new Mock<ILogger<Extractor>>().Object);
            var clientfactory = new Mock<IHttpClientFactory>();
            var httpClient = new HttpClient();
            clientfactory.Setup(s => s.CreateClient(It.IsAny<string>())).Returns(httpClient);
            var client = new ClientDownloader(clientfactory.Object, new Mock<ILogger<ClientDownloader>>().Object);
            var manifest = await client.DownloadManifest();
            manifest.Entries = manifest.Entries.Select(s =>
            {
                s.File = s.File.Replace('\\', Path.DirectorySeparatorChar);
                return s;
            }).ToArray();
            var name = $"NostaleData{Path.DirectorySeparatorChar}NScliData_UK.NOS";
            manifest.Entries = manifest.Entries.Where(s => name == s.File).ToArray();
            await client.DownloadClientAsync(manifest);

            var dest = $".{Path.DirectorySeparatorChar}output{Path.DirectorySeparatorChar}parser{Path.DirectorySeparatorChar}";
            var fileInfo =
                new FileInfo($".{Path.DirectorySeparatorChar}output{Path.DirectorySeparatorChar}{name}");
            await extractor.ExtractAsync(fileInfo, dest, true);
            string text = await File.ReadAllTextAsync($"{dest}conststring_UK.dat");
            var split = text.Split('\r');
            var dictionary = new Dictionary<int, string>();
            foreach (var line in split)
            {
                var splitedline = line.Split('\v');
                if (splitedline.Length > 1)
                {
                    var id = int.Parse(splitedline[0]);
                    if (id < 10000)
                    {
                        continue;
                    }
                    dictionary.Add(id - 10000, splitedline[1]);
                }
            }
            var builder = new StringBuilder();
            builder.AppendLine(@"//  __  _  __    __   ___ __  ___ ___");
            builder.AppendLine(@"// |  \| |/__\ /' _/ / _//__\| _ \ __|");
            builder.AppendLine(@"// | | ' | \/ |`._`.| \_| \/ | v / _|");
            builder.AppendLine(@"// |_|\__|\__/ |___/ \__/\__/|_|_\___|");
            builder.AppendLine(@"// -----------------------------------");
            builder.AppendLine("");
            builder.AppendLine(@"namespace NosCore.Packets.Enumerations");
            builder.AppendLine(@"{");
            builder.AppendLine(@"    public enum Game18NConstString : short");
            builder.AppendLine(@"    {");
            var enums = Enum.GetValues(typeof(Game18NConstString)).Cast<Game18NConstString?>().ToList();

            var nullvalues = new List<KeyValuePair<int, string>>();
            foreach (var value in dictionary.OrderBy(s => s.Key))
            {
                var enumeration = enums.FirstOrDefault(s => (int)(s!) == value.Key);
                if (enumeration == null)
                {
                    nullvalues.Add(value);
                    continue;
                }
                builder.AppendLine("        /// <summary>");
                builder.AppendLine($"        /// {value.Value}");
                builder.AppendLine("        /// <summary>");
                builder.AppendLine(@$"        {enumeration} = {(int)enumeration!},");
            }
            builder.AppendLine(@"    }");
            builder.AppendLine(@"}");
            var path = Path.Combine(Directory.GetCurrentDirectory(), $"..{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}src{Path.DirectorySeparatorChar}NosCore.Packets{Path.DirectorySeparatorChar}Enumerations{Path.DirectorySeparatorChar}");
            var file = $"{path}Game18NConstString.cs";
            Approvals.AssertText(builder.ToString(), await File.ReadAllTextAsync(file));
            Assert.AreEqual("[]", JsonConvert.SerializeObject(nullvalues));
        }
    }
}
