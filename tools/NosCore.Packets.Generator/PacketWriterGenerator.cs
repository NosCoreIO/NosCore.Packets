//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace NosCore.Packets.Generator
{
    [Generator]
    public class PacketWriterGenerator : IIncrementalGenerator
    {
        private const string PacketIndexAttribute = "NosCore.Packets.Attributes.PacketIndexAttribute";
        private const string PacketHeaderAttribute = "NosCore.Packets.Attributes.PacketHeaderAttribute";

        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            var packets = context.SyntaxProvider
                .ForAttributeWithMetadataName(PacketHeaderAttribute,
                    static (node, _) => true,
                    static (ctx, _) => Describe((INamedTypeSymbol)ctx.TargetSymbol))
                .Where(static p => p is not null)
                .Collect();

            context.RegisterSourceOutput(packets, static (spc, all) => Emit(spc, all!));
        }

        private static PacketModel? Describe(INamedTypeSymbol type)
        {
            if (type.IsAbstract)
            {
                return null;
            }

            var header = type.GetAttributes()
                .FirstOrDefault(a => IsOrDerivesFrom(a.AttributeClass, PacketHeaderAttribute))
                ?.ConstructorArguments.FirstOrDefault().Value as string;
            if (string.IsNullOrEmpty(header))
            {
                return null;
            }

            var fields = new List<FieldModel>();
            foreach (var member in AllProperties(type))
            {
                var index = member.GetAttributes()
                    .FirstOrDefault(a => IsOrDerivesFrom(a.AttributeClass, PacketIndexAttribute));
                if (index is null)
                {
                    continue;
                }

                // PacketListIndexAttribute derives from PacketIndexAttribute; lists are not
                // generated, so the whole packet falls back rather than losing the field.
                if (index.AttributeClass?.ToDisplayString() != PacketIndexAttribute)
                {
                    return null;
                }

                var kind = Classify(member.Type);
                if (kind == FieldKind.Unsupported)
                {
                    return null;
                }

                fields.Add(new FieldModel(
                    (int)index.ConstructorArguments[0].Value!,
                    member.Name,
                    kind,
                    Named(index, "IsOptional"),
                    Named(index, "EscapeSpaces"),
                    NamedString(index, "SpecialSeparator")));
            }

            if (fields.Count == 0)
            {
                return null;
            }

            fields.Sort((a, b) => a.Index.CompareTo(b.Index));
            return new PacketModel(type.ToDisplayString(), type.Name, header!, fields);
        }

        private static IEnumerable<IPropertySymbol> AllProperties(INamedTypeSymbol type)
        {
            for (var current = type; current is not null; current = current.BaseType)
            {
                foreach (var p in current.GetMembers().OfType<IPropertySymbol>())
                {
                    yield return p;
                }
            }
        }

        private static bool IsOrDerivesFrom(INamedTypeSymbol? attribute, string metadataName)
        {
            for (var current = attribute; current is not null; current = current.BaseType)
            {
                if (current.ToDisplayString() == metadataName)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool Named(AttributeData a, string name) =>
            a.NamedArguments.Any(n => n.Key == name && n.Value.Value is true);

        private static string? NamedString(AttributeData a, string name) =>
            a.NamedArguments.FirstOrDefault(n => n.Key == name).Value.Value as string;

        // Only the flat shapes are generated; lists, sub-packets and injected packets stay on
        // the expression tree, which the runtime falls back to.
        private static FieldKind Classify(ITypeSymbol type)
        {
            var underlying = type is INamedTypeSymbol { IsGenericType: true } n &&
                             n.ConstructedFrom.SpecialType == SpecialType.System_Nullable_T
                ? n.TypeArguments[0]
                : type;
            var nullable = !SymbolEqualityComparer.Default.Equals(underlying, type);

            if (underlying.SpecialType == SpecialType.System_String)
            {
                return FieldKind.String;
            }

            if (underlying.SpecialType == SpecialType.System_Boolean)
            {
                return nullable ? FieldKind.NullableBool : FieldKind.Bool;
            }

            if (underlying.TypeKind == TypeKind.Enum)
            {
                return nullable ? FieldKind.NullableEnum : FieldKind.Enum;
            }

            return underlying.SpecialType switch
            {
                SpecialType.System_Byte or SpecialType.System_SByte or SpecialType.System_Int16
                    or SpecialType.System_UInt16 or SpecialType.System_Int32 or SpecialType.System_UInt32
                    or SpecialType.System_Int64 or SpecialType.System_UInt64
                    => nullable ? FieldKind.NullableNumber : FieldKind.Number,
                _ => FieldKind.Unsupported
            };
        }

        private static void Emit(SourceProductionContext context, ImmutableArray<PacketModel?> packets)
        {
            var models = packets.Where(p => p is not null).Select(p => p!)
                .GroupBy(p => p.FullName).Select(g => g.First())
                .OrderBy(p => p.FullName).ToList();

            var sb = new StringBuilder();
            sb.AppendLine("// <auto-generated/>");
            sb.AppendLine("#nullable enable");
            sb.AppendLine("#pragma warning disable CS0618 // obsolete packets still serialize");
            sb.AppendLine("using System.Text;");
            sb.AppendLine();
            sb.AppendLine("namespace NosCore.Packets.Generated");
            sb.AppendLine("{");
            sb.AppendLine("    public static class PacketWriters");
            sb.AppendLine("    {");
            sb.AppendLine("        public static bool TryWrite(global::NosCore.Packets.Interfaces.IPacket packet, out string result)");
            sb.AppendLine("        {");
            sb.AppendLine("            switch (packet)");
            sb.AppendLine("            {");

            foreach (var model in models)
            {
                sb.AppendLine($"                case global::{model.FullName} p:");
                sb.AppendLine($"                    result = Write{model.Name}(p);");
                sb.AppendLine("                    return true;");
            }

            sb.AppendLine("                default:");
            sb.AppendLine("                    result = string.Empty;");
            sb.AppendLine("                    return false;");
            sb.AppendLine("            }");
            sb.AppendLine("        }");

            foreach (var model in models)
            {
                EmitWriter(sb, model);
            }

            sb.AppendLine("    }");
            sb.AppendLine("}");

            context.AddSource("PacketWriters.g.cs", SourceText.From(sb.ToString(), Encoding.UTF8));
        }

        private static void EmitWriter(StringBuilder sb, PacketModel model)
        {
            var last = model.Fields[model.Fields.Count - 1];
            sb.AppendLine();
            sb.AppendLine($"        private static string Write{model.Name}(global::{model.FullName} p)");
            sb.AppendLine("        {");
            sb.AppendLine("            var sb = new StringBuilder(64);");
            sb.AppendLine($"            sb.Append(\"{model.Header}\");");

            foreach (var f in model.Fields)
            {
                var sep = f.SpecialSeparator ?? " ";
                var literal = sep.Replace("\\", "\\\\").Replace("\"", "\\\"");
                var isLast = f.Index == last.Index;
                sb.AppendLine();
                switch (f.Kind)
                {
                    case FieldKind.String:
                        sb.AppendLine($"            if (p.{f.Name} is null)");
                        sb.AppendLine("            {");
                        if (!f.IsOptional)
                        {
                            sb.AppendLine($"                sb.Append(\"{literal}-\");");
                        }
                        sb.AppendLine("            }");
                        sb.AppendLine("            else");
                        sb.AppendLine("            {");
                        sb.AppendLine($"                sb.Append(\"{literal}\").Append(");
                        sb.AppendLine(isLast && !f.EscapeSpaces
                            ? $"                    p.{f.Name});"
                            : $"                    p.{f.Name}.Replace(\"{literal}\", \"^\"){(f.EscapeSpaces ? ".Replace(\" \", \"^\")" : "")});");
                        sb.AppendLine("            }");
                        break;
                    case FieldKind.Bool:
                        sb.AppendLine($"            sb.Append(\"{literal}\").Append(p.{f.Name} ? '1' : '0');");
                        break;
                    case FieldKind.NullableBool:
                        sb.AppendLine($"            if (p.{f.Name} is {{ }} b{f.Index})");
                        sb.AppendLine("            {");
                        sb.AppendLine($"                sb.Append(\"{literal}\").Append(b{f.Index} ? '1' : '0');");
                        sb.AppendLine("            }");
                        break;
                    case FieldKind.Enum:
                        sb.AppendLine($"            sb.Append(\"{literal}\").Append((long)p.{f.Name});");
                        break;
                    case FieldKind.NullableEnum:
                        sb.AppendLine($"            if (p.{f.Name} is {{ }} e{f.Index})");
                        sb.AppendLine("            {");
                        sb.AppendLine($"                sb.Append(\"{literal}\").Append((long)e{f.Index});");
                        sb.AppendLine("            }");
                        break;
                    case FieldKind.Number:
                        sb.AppendLine($"            sb.Append(\"{literal}\").Append(p.{f.Name});");
                        break;
                    case FieldKind.NullableNumber:
                        sb.AppendLine($"            if (p.{f.Name} is {{ }} v{f.Index})");
                        sb.AppendLine("            {");
                        sb.AppendLine($"                sb.Append(\"{literal}\").Append(v{f.Index});");
                        sb.AppendLine("            }");
                        if (!f.IsOptional)
                        {
                            sb.AppendLine("            else");
                            sb.AppendLine("            {");
                            sb.AppendLine($"                sb.Append(\"{literal}-1\");");
                            sb.AppendLine("            }");
                        }
                        break;
                }
            }

            sb.AppendLine();
            sb.AppendLine("            return sb.ToString();");
            sb.AppendLine("        }");
        }

        private enum FieldKind
        {
            Unsupported,
            String,
            Bool,
            NullableBool,
            Enum,
            NullableEnum,
            Number,
            NullableNumber
        }

        private sealed record FieldModel(int Index, string Name, FieldKind Kind, bool IsOptional,
            bool EscapeSpaces, string? SpecialSeparator);

        private sealed record PacketModel(string FullName, string Name, string Header, List<FieldModel> Fields);
    }
}
