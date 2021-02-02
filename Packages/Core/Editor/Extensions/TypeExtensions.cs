using System;

namespace UnityAtoms
{
    internal static class TypeExtensions
    {
        public static bool IsUnitySerializable(this Type type)
        {
            return type.IsSerializable || type.IsSubclassOf(typeof(UnityEngine.Object));
        }
    }
}

