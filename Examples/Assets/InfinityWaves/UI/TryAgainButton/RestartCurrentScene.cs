using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartCurrentScene : MonoBehaviour
{
    public void Do() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
