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

        /// <summary>
        /// Constants for defining DefaultExecutionOrder.
        /// </summary>
        public static class ExecutionOrder
        {
            public const int VARIABLE_RESETTER = -200;
            public const int VARIABLE_INSTANCER = -100;
        }

        /// <summary>
        /// Determine if we are working the Unity Atoms source library / repo or not.
        /// </summary>
        /// <returns>`true` if we are working in the Unity Atoms source library / repo, otherwise `false`.</returns>
        public static bool IsUnityAtomsRepo
        {
            get => System.Environment.CurrentDirectory.Contains("unity-atoms/Examples");
        }
    }
}
