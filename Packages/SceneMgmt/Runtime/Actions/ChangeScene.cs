using UnityEngine;
using UnityEngine.SceneManagement;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Action to change scene.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Scene Management/Change Scene")]
    public sealed class ChangeScene : AtomAction
    {
        /// <summary>
        /// Scene to change to.
        /// </summary>
        [SerializeField]
        private StringReference _sceneName = null;

        /// <summary>
        /// Change the scene.
        /// </summary>
        public override void Do()
        {
            SceneManager.LoadScene(_sceneName.Value);
        }
    }
}

