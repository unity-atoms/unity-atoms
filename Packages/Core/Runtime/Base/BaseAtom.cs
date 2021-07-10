using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityAtoms
{
    /// <summary>
    /// None generic base class for all Atoms.
    /// </summary>
    [AtomsSearchable]
    public abstract class BaseAtom : ScriptableObject
    {
        /// <summary>
        /// A description of the Atom made for documentation purposes.
        /// </summary>
        [SerializeField]
        [TextArea(3, 6)]
        private string _developerDescription;

        /// <summary>
        /// Manage how the scriptable object is loaded/unloaded or if it reset its value between scene
        /// </summary>
        /// <param name="scope"></param>
        internal void ManageLifetime(Scope scope)
        {
            switch (scope)
            {
                case Scope.Global:
                    hideFlags = HideFlags.DontUnloadUnusedAsset;
                    break;
                case Scope.Scene:
                    SceneManager.activeSceneChanged += OnActiveSceneChanged;
                    break;
                case Scope.Unmanaged:
                    break;
            }
        }

        /// <summary>
        /// Callback called when main scene is changing
        /// </summary>
        /// <remarks>
        /// Use this callback to reset the SO value when the scope is set to <c>Scope.Scene</c>
        /// </remarks>
        /// <param name="current">Current scene</param>
        /// <param name="next">Next scene</param>
        protected virtual void OnActiveSceneChanged(Scene current, Scene next) { }
    }
}
