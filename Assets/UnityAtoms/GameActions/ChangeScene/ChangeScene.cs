using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "UnityAtoms/Game Actions/Change Scene")]
    public class ChangeScene : VoidAction
    {
        [SerializeField]
        private string SceneName;

        public override void Do()
        {
            SceneManager.LoadScene(SceneName);
        }
    }

}

