using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Scene Management/Change Scene")]
    public sealed class ChangeScene : VoidAction
    {
        [FormerlySerializedAs("SceneName")]
        [SerializeField]
        private StringReference _sceneName;

        public override void Do()
        {
            SceneManager.LoadScene(_sceneName.Value);
        }
    }
}

