using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms.Extensions
{
    public static class ArrayExtensions
    {
        public static T GetRandom<T>(this T[] array)
        {
            if (array == null || array.Length <= 0)
            {
                return default(T);
            }

            return array[Random.Range(0, array.Length)];
        }
    }
}