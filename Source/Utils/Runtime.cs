using System;

namespace UnityAtoms
{
    /// <summary>
    /// Internal constant and static readonly members for runtime usage.
    /// </summary>
    internal static class Runtime
    {
        internal static class Constants
        {
            /// <summary>
            /// Prefix that should be pre-pended to all Debug.Logs made from UnityAtoms to help immediately inform
            /// a user that those logs are made from this library.
            /// </summary>
            public const string LOG_PREFIX = "UnityAtoms :: ";
        }
        public static bool IsUnityAtomsRepo { get => System.Environment.CurrentDirectory.Contains("unity-atoms/UnityAtomsTestsAndExamples"); }
    }
}
