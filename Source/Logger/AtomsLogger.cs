using UnityEngine;

namespace UnityAtoms.Logger
{
    public static class AtomsLogger
    {
        private const string LogPrefix = "Unity Atoms :: ";

        public static void Log(string msg)
        {
            Debug.Log(LogPrefix + msg);
        }

        public static void Warning(string msg)
        {
            Debug.LogWarning(LogPrefix + msg);
        }

        public static void Error(string msg)
        {
            Debug.LogError(LogPrefix + msg);
        }
    }
}

