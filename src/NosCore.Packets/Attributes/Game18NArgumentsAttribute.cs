using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NosCore.Packets.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class Game18NArgumentsAttribute : Attribute
    {
        public Game18NArgumentsAttribute(params Type[] argumentTypes)
        {
            ArgumentTypes = argumentTypes;
        }

        public Type[] ArgumentTypes { get; set; }
    }
}
