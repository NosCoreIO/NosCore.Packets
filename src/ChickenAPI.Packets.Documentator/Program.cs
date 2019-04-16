using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.Documentator
{
    internal class Program
    {
        private static IEnumerable<IGrouping<string, Type>> GetPacketsWithinNamespace(string name)
        {
            return typeof(UnresolvedPacket).Assembly.GetTypes()
                .Where(s => s.GetInterfaces().Any(p => p == typeof(IPacket)))
                .Where(s => !s.IsAbstract)
                .Where(s => s.Namespace.Contains(name))
                .GroupBy(s => s.Namespace.Substring(s.Namespace.LastIndexOf('.') + 1));
        }

        private static IEnumerable<Type> GetPackets(IEnumerable<Type> types)
        {
            return types.Where(s => s.GetCustomAttribute<PacketHeaderAttribute>() != null).OrderBy(s => s.GetCustomAttribute<PacketHeaderAttribute>().Identification.ToLower());
        }

        private static void Main(string[] args)
        {
            var builder = new StringBuilder();
            builder.Append("# ChickenAPI.Packets's Documentation\n");
            builder.Append("## ClientPackets :\n");
            foreach (IGrouping<string, Type> packetGroup in GetPacketsWithinNamespace("ClientPackets"))
            {
                builder.Append("\n");
                builder.Append($"### {packetGroup.Key}\n");
                foreach (Type packet in GetPackets(packetGroup))
                {
                    builder.Append($"- [{packet.GetCustomAttribute<PacketHeaderAttribute>().Identification}](src/ChickenAPI.Packets/ClientPackets/{packetGroup.Key}/{packet}.cs)\n");
                }
            }

            builder.Append("\n");
            builder.Append("## ServerPackets :\n");
            foreach (IGrouping<string, Type> packetGroup in GetPacketsWithinNamespace("ServerPackets"))
            {
                builder.Append($"\n");
                builder.Append($"### {packetGroup.Key}\n");
                foreach (Type packet in GetPackets(packetGroup))
                {
                    builder.Append($"- [{packet.GetCustomAttribute<PacketHeaderAttribute>().Identification}](src/ChickenAPI.Packets/ServerPackets/{packetGroup.Key}/{packet}.cs)\n");
                }
            }

            string file = "PACKET_LIST.md";
            if (args.Any())
            {
                file = args[0];
            }


            File.WriteAllText(file, builder.ToString());
            return;
        }
    }
}