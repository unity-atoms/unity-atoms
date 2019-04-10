using UnityEngine;

namespace UnityAtoms.Logger
{
    public static class AtomsLogger
    {
        private const string LOG_PREFIX = "Unity Atoms :: ";

        public static void Log(string msg)
        {
            Debug.Log(LOG_PREFIX + msg);
        }

        public static void Warning(string msg)
        {
            Debug.LogWarning(LOG_PREFIX + msg);
        }

        public static void Error(string msg)
        {
            Debug.LogError(LOG_PREFIX + msg);
        }
    }
}

