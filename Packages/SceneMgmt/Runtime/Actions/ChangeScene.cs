using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Action to change scene.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Scene Management/Change Scene")]
    public sealed class ChangeScene : VoidAction
    {
        /// <summary>
        /// Scene to change to.
        /// </summary>
        [FormerlySerializedAs("SceneName")]
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

