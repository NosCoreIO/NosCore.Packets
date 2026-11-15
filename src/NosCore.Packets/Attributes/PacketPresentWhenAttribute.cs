//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;

namespace NosCore.Packets.Attributes
{
    // An optional field that is on the line only for some values of an earlier field, such as the part of
    // an in packet that depends on the kind of entity.
    [AttributeUsage(AttributeTargets.Property)]
    public class PacketPresentWhenAttribute : Attribute
    {
        public PacketPresentWhenAttribute(string field, params object[] values)
        {
            Field = field;
            Values = values;
        }

        public string Field { get; }

        public object[] Values { get; }
    }
}
