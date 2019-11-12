using System;

namespace UnityAtoms
{
    /// <summary>
    /// Internal constant and static readonly members for runtime usage.
    /// </summary>
    public static class Runtime
    {
        /// <summary>
        /// Runtime constants
        /// </summary>
        public static class Constants
        {
            /// <summary>
            /// Prefix that should be pre-pended to all Debug.Logs made from UnityAtoms to help immediately inform a user that those logs are made from this library.
            /// </summary>
            public const string LOG_PREFIX = "UnityAtoms :: ";
        }

#if UNITY_EDITOR
        private static bool? _isUnityAtomsRepo = false;
#endif

        /// <summary>
        /// Determine if we are working the Unity Atoms source library / repo or not.
        /// </summary>
        /// <returns>`true` if we are working in the Unity Atoms source library / repo, otherwise `false`.</returns>
        public static bool IsUnityAtomsRepo
        {
            #if !UNITY_EDITOR
            get => System.Environment.CurrentDirectory.Contains("unity-atoms/Examples");
#else
            get => (_isUnityAtomsRepo = (_isUnityAtomsRepo ?? System.Environment.CurrentDirectory.Contains("unity-atoms/Examples"))).Value;
            set => _isUnityAtomsRepo = value;
#endif

        }
    }
}
