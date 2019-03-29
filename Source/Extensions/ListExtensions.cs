using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms.Extensions
{
    // Create an Action delegates that takes 5 parameters. Not included in the standard lib.
    public delegate void Action<T1, T2, T3, T4, T5>(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5);

    public static class ListExtensions
    {
        public static void ForEach<T, P1>(this List<T> list, Action<T, P1> action, P1 param1)
        {
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                action(list[i], param1);
            }
        }

        public static void ForEach<T, P1, P2>(this List<T> list, Action<T, P1, P2> action, P1 param1, P2 param2)
        {
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                action(list[i], param1, param2);
            }
        }

        public static void ForEach<T, P1, P2, P3>(this List<T> list, Action<T, P1, P2, P3> action, P1 param1, P2 param2, P3 param3)
        {
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                action(list[i], param1, param2, param3);
            }
        }

        public static void ForEach<T, V, P1>(this List<T> list, Func<T, V> selector, Action<V, P1> action, P1 param1)
        {
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                action(selector(list[i]), param1);
            }
        }

        public static void ForEach<T, V, P1, P2>(this List<T> list, Func<T, V> selector, Action<V, P1, P2> action, P1 param1, P2 param2)
        {
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                action(selector(list[i]), param1, param2);
            }
        }

        public static void ForEach<T, V, P1, P2, P3>(this List<T> list, Func<T, V> selector, Action<V, P1, P2, P3> action, P1 param1, P2 param2, P3 param3)
        {
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                action(selector(list[i]), param1, param2, param3);
            }
        }

        public static void ForEach<T>(this List<T> list, Action<T, int> action)
        {
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                action(list[i], i);
            }
        }

        public static void ForEach<T, P1>(this List<T> list, Action<T, int, P1> action, P1 param1)
        {
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                action(list[i], i, param1);
            }
        }

        public static void ForEach<T, P1, P2>(this List<T> list, Action<T, int, P1, P2> action, P1 param1, P2 param2)
        {
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                action(list[i], i, param1, param2);
            }
        }

        public static void ForEach<T, P1, P2, P3>(this List<T> list, Action<T, int, P1, P2, P3> action, P1 param1, P2 param2, P3 param3)
        {
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                action(list[i], i, param1, param2, param3);
            }
        }

        public static R Reduce<R, T>(this List<T> list, Func<R, R, R> reducer, Func<T, R> getValue, R initialValue, Func<T, bool> skip = null)
        {
            R accumulator = initialValue;
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                if (skip != null && skip(list[i]))
                {
                    continue;
                }

                accumulator = reducer(accumulator, getValue(list[i]));
            }

            return accumulator;
        }

        public static R Reduce<R, T, A>(this List<T> list, Func<R, R, A, R> reducer, Func<T, R> getValue, R initialValue, A reducerArg1, Func<T, bool> skip = null)
        {
            R accumulator = initialValue;
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                if (skip != null && skip(list[i]))
                {
                    continue;
                }

                accumulator = reducer(accumulator, getValue(list[i]), reducerArg1);
            }

            return accumulator;
        }

        public static float ReturnMaxFloat(float acc, float cur) { return Mathf.Max(acc, cur); }
        public static float ReturnMinFloat(float acc, float cur) { return Mathf.Min(acc, cur); }

        public static T First<T>(this List<T> list, Func<T, bool> func)
        {
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                if (func(list[i])) return list[i];
            }

            return default(T);
        }

        public static bool Some<T>(this List<T> list, Func<T, bool> func)
        {
            return EqualityComparer<T>.Default.Equals(list.First(func), default(T));
        }

        public static bool AddIfNotExists<T>(this List<T> list, T item)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
                return true;
            }

            return false;
        }

        public static List<T> ChainableAdd<T>(this List<T> list, T item)
        {
            list.Add(item);
            return list;
        }

        public static T GetOrInstantiate<T>(this List<T> list, UnityEngine.Object prefab, Vector3 position, Quaternion quaternion, Func<T, bool> condition) where T : UnityEngine.Component
        {
            var component = list.First(condition);

            if (component != null)
            {
                component.transform.position = position;
                component.transform.rotation = quaternion;
                return component;
            }

            var newComponent = GameObject.Instantiate(prefab, position, quaternion) as T;
            list.Add(newComponent);
            return newComponent;
        }

        public static GameObject GetOrInstantiate(this List<GameObject> list, UnityEngine.Object prefab, Vector3 position, Quaternion quaternion, Func<GameObject, bool> condition)
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

        public static T InstantiateAndAdd<T>(this List<T> list, UnityEngine.Object prefab, Vector3 position, Quaternion quaternion) where T : UnityEngine.Component
        {
            var component = GameObject.Instantiate(prefab, position, quaternion) as T;
            list.Add(component);
            return component;
        }
    }
}
