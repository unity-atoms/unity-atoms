using UnityEngine;

namespace UnityAtoms.Logger
{
    public static class AtomsLogger
    {
        private const string logPrefix = "Unity Atoms :: ";

        public static void Log(string msg)
        {
            Debug.Log(logPrefix + msg);
        }

        public static void Warning(string msg)
        {
            Debug.LogWarning(logPrefix + msg);
        }

        public static void Error(string msg)
        {
            Debug.LogError(logPrefix + msg);
        }
    }
}

