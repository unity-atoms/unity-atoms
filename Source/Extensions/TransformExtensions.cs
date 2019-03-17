using UnityEngine;
using System;
using System.Collections;

namespace UnityAtoms.Extensions
{
    public static class TransformExtensions
    {

        /* Finds a child to this transform by name. Searches not only the first level in the 
         * tree hierarchy of child objects, but all the children, grand children, and so on.  
         */
        public static Transform FindDeepChild(this Transform parent, string name)
        {
            var result = parent.Find(name);

            if (result != null)
                return result;

            for (int i = 0; i < parent.childCount; ++i)
            {
                result = parent.GetChild(i).FindDeepChild(name);
                if (result != null)
                    return result;
            }

            return null;
        }

        /* Traverse all the children of the transform and executes the action on this transform,
         * as well as on all the children.
         */
        public static void TraverseAndExecute(this Transform current, Action<Transform> action)
        {
            action(current);

            for (int i = 0; i < current.childCount; ++i)
            {
                current.GetChild(i).TraverseAndExecute(action);
            }
        }

        /* Traverse all the children of the transform and executes the func on this transform,
         * as well as on all the children. Will return true if all of the funcs returns true.
         */
        public static bool TraverseExecuteAndCheck(this Transform current, Func<Transform, bool> func)
        {
            bool ret = func(current);

            for (int i = 0; i < current.childCount; ++i)
            {
                var temp = current.GetChild(i).TraverseExecuteAndCheck(func);
                if (!temp)
                    ret = false;
            }

            return ret;
        }

        public static void ForEachChild(this Transform transform, Action<Transform> action)
        {
            for (int i = 0; i < transform.childCount; ++i)
            {
                action(transform.GetChild(i));
            }
        }

        public static void ForEachChild<P1>(this Transform transform, Action<Transform, P1> action, P1 param1)
        {
            for (int i = 0; i < transform.childCount; ++i)
            {
                action(transform.GetChild(i), param1);
            }
        }

        public static void ForEachChild<P1, P2>(this Transform transform, Action<Transform, P1, P2> action, P1 param1, P2 param2)
        {
            for (int i = 0; i < transform.childCount; ++i)
            {
                action(transform.GetChild(i), param1, param2);
            }
        }

        public static void ForEachChild<P1, P2, P3>(this Transform transform, Action<Transform, P1, P2, P3> action, P1 param1, P2 param2, P3 param3)
        {
            for (int i = 0; i < transform.childCount; ++i)
            {
                action(transform.GetChild(i), param1, param2, param3);
            }
        }

        public static void ForEachChild(this Transform transform, Action<Transform, int> action)
        {
            for (int i = 0; i < transform.childCount; ++i)
            {
                action(transform.GetChild(i), i);
            }
        }

        public static void ForEachChild<P1>(this Transform transform, Action<Transform, int, P1> action, P1 param1)
        {
            for (int i = 0; i < transform.childCount; ++i)
            {
                action(transform.GetChild(i), i, param1);
            }
        }

        public static void ForEachChild<P1, P2>(this Transform transform, Action<Transform, int, P1, P2> action, P1 param1, P2 param2)
        {
            for (int i = 0; i < transform.childCount; ++i)
            {
                action(transform.GetChild(i), i, param1, param2);
            }
        }

        public static void ForEachChild<P1, P2, P3>(this Transform transform, Action<Transform, int, P1, P2, P3> action, P1 param1, P2 param2, P3 param3)
        {
            for (int i = 0; i < transform.childCount; ++i)
            {
                action(transform.GetChild(i), i, param1, param2, param3);
            }
        }

        public static Transform AddParent(this Transform transform, Transform parent)
        {
            transform.parent = parent;
            return transform;
        }
    }
}
