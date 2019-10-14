using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace UnityAtoms.SceneMgmt
{
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Scene Management/Change Scene")]
    public sealed class ChangeScene : VoidAction
    {
        [FormerlySerializedAs("SceneName")]
        [SerializeField]
        private StringReference _sceneName = null;

        public override void Do()
        {
            SceneManager.LoadScene(_sceneName.Value);
        }
    }
}

