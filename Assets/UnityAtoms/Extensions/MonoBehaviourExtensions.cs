using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
    public static class MonoBehaviourExtensions
    {
        public static void WaitThenDo(this MonoBehaviour mb, float delay, Action onComplete)
        {
            mb.StartCoroutine(Routine(delay, onComplete));
        }

        static IEnumerator Routine(float delay, Action onComplete)
        {
            yield return new WaitForSeconds(delay);
            onComplete();
        }
    }
}