using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityAtoms.Examples
{
    public class RestartCurrentScene : MonoBehaviour
    {
        public void Do() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
