//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;

namespace NosCore.Packets.Attributes
{
    // Game18NArguments that hold the rest of the line as one text, spaces and leading zeros included,
    // for some values of an earlier field, such as the free text of an announcement.
    [AttributeUsage(AttributeTargets.Property)]
    public class PacketFreeTextWhenAttribute : Attribute
    {
        public PacketFreeTextWhenAttribute(string field, params object[] values)
        {
            Field = field;
            Values = values;
        }

        public string Field { get; }

        public object[] Values { get; }
    }
}
