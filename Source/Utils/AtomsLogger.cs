using UnityEngine;

namespace UnityAtoms.Logger
{
    public static class AtomsLogger
    {
        private const string LOG_PREFIX = "Unity Atoms :: ";

        public static void Log(string msg)
        {
#if UNITY_EDITOR
            Debug.Log(LOG_PREFIX + msg);
#endif
        }

        public static void Warning(string msg)
        {
#if UNITY_EDITOR
            Debug.LogWarning(LOG_PREFIX + msg);
#endif
        }

        public static void Error(string msg)
        {
#if UNITY_EDITOR
            Debug.LogError(LOG_PREFIX + msg);
#endif
        }
    }
}

