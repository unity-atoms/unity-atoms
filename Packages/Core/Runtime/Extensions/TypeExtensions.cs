using System;

namespace UnityAtoms
{
    internal static class TypeExtensions
    {
        public static bool IsSameOrSubclass(this Type type, Type other) => type.IsSubclassOf(other) || type == other;
    }
}
