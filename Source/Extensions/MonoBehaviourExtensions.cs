using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms.Extensions
{
    public static class MonoBehaviourExtensions
    {
        public static void ClearInterval(this MonoBehaviour mb, Coroutine coroutine)
        {
            mb.StopCoroutine(coroutine);
        }

        public static Coroutine SetTimeout(this MonoBehaviour mb, Action function, float delay)
        {
            return mb.StartCoroutine(SetTimeout(function, delay));
        }

        static IEnumerator SetTimeout(Action function, float delay)
        {
            yield return new WaitForSeconds(delay);
            function();
        }

        public static Coroutine SetInterval(this MonoBehaviour mb, Action function, float delay)
        {
            return mb.StartCoroutine(SetInterval(function, delay));
        }

        static IEnumerator SetInterval(Action function, float delay)
        {
            while (true && function != null)
            {
                yield return new WaitForSeconds(delay);
                function();
            }
        }

        // Tries to get a component on the the MonoBehaviour's GameObject. If the component doesn't exists it adds it and return the newly added component.
        public static T GetOrAddComponent<T>(this MonoBehaviour mb) where T : Component
        {
            return mb.gameObject.GetOrAddComponent<T>();
        }
    }
}