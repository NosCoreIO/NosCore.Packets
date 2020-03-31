//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// 
// Copyright (C) 2019 - NosCore
// 
// NosCore is a free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace NosCore.Packets.Benchmark.SaltyEmu
{
    /// <summary>
    ///     https://stackoverflow.com/questions/6582259/fast-creation-of-objects-instead-of-activator-createinstancetype
    ///     https://github.com/KSemenenko/CreateInstance
    ///     https://blogs.msdn.microsoft.com/seteplia/2017/02/01/dissecting-the-new-constraint-in-c-a-perfect-example-of-a-leaky-abstraction/
    ///     Thanks to these articles, it was designed to fasten the PacketFactory's packet instanciation
    /// </summary>
    public static class TypeExtension
    {
        private static readonly ConcurrentDictionary<Type, Func<object?>?> Constructors =
            new ConcurrentDictionary<Type, Func<object?>?>();

        /// <summary>
        ///     Gets the default constructor delegate (empty parameters)
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Func<object> GetDefaultConstructorDelegate(this Type type) =>
            (Func<object>) GetConstructorDelegate(type, typeof(Func<object>));

        /// <summary>
        ///     Retrieves the constructor of the given type based on the given delegate type
        /// </summary>
        /// <param name="type"></param>
        /// <param name="delegateType"></param>
        /// <returns></returns>
        public static Delegate GetConstructorDelegate(this Type type, Type delegateType)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            if (delegateType == null)
            {
                throw new ArgumentNullException(nameof(delegateType));
            }

            Type[] genericArguments = delegateType.GetGenericArguments();
            Type[] argTypes = genericArguments.Length > 1
                ? genericArguments.Take(genericArguments.Length - 1).ToArray()
                : Type.EmptyTypes;

            ConstructorInfo? constructor = type.GetConstructor(argTypes);
            if (constructor == null)
            {
                if (argTypes.Length == 0)
                {
                    throw new InvalidOperationException(
                        $"Type '{type.Name}' doesn't have a parameterless constructor.");
                }

                throw new InvalidOperationException($"Type '{type.Name}' doesn't have the requested constructor.");
            }

            var dynamicMethod = new DynamicMethod("DM$OBJ_FACTORY_" + type.Name, type, argTypes, type);
            ILGenerator ilGen = dynamicMethod.GetILGenerator();
            for (int i = 0; i < argTypes.Length; i++)
            {
                ilGen.Emit(OpCodes.Ldarg, i);
            }

            ilGen.Emit(OpCodes.Newobj, constructor);
            ilGen.Emit(OpCodes.Ret);
            return dynamicMethod.CreateDelegate(delegateType);
        }

        /// <summary>
        ///     This extension is much faster than
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static object? CreateInstance(this Type type)
        {
            if (Constructors.TryGetValue(type, out Func<object?>? constructor))
            {
                return constructor!();
            }

            constructor = type.GetDefaultConstructorDelegate();
            Constructors.TryAdd(type, constructor);
            return constructor();
        }
    }
}