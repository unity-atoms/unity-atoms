using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityAtoms.Examples
{
    /// <summary>
    /// Restart the current scene.
    /// </summary>
    public class RestartCurrentScene : MonoBehaviour
    {
        public void Do() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
