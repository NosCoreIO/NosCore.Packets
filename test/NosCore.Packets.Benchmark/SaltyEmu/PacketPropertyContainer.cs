//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using NosCore.Packets.Attributes;

namespace NosCore.Packets.Benchmark.SaltyEmu
{
    public class PacketPropertyContainer
    {
        public PacketIndexAttribute? PacketIndex { get; set; }
        public PropertyInfo? PropertyInfo { get; set; }
        public IEnumerable<ValidationAttribute?>? Validations { get; set; }
    }
}