using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
    internal static class IListExtensions
    {
        public static T First<T>(this IList<T> list, Func<T, bool> func)
        {
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                if (func(list[i])) return list[i];
            }

            return default(T);
        }

        public static bool Exists<T>(this IList<T> list, Func<T, bool> func)
        {
            var first = list.First<T>(func);
            return first != null ? true : false;
        }

        public static GameObject GetOrInstantiate(this IList<GameObject> list, UnityEngine.Object prefab, Vector3 position, Quaternion quaternion, Func<GameObject, bool> condition)
        {
            var component = list.First(condition);

            if (component != null)
            {
                component.transform.position = position;
                component.transform.rotation = quaternion;
                return component;
            }

            var newGameObject = GameObject.Instantiate(prefab, position, quaternion) as GameObject;
            list.Add(newGameObject);
            return newGameObject;
        }
    }
}
