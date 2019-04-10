using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Scene Management/Void Actions/Quit Application")]
    public sealed class QuitApplication : VoidAction
    {
        public override void Do()
        {
            Application.Quit();
        }
    }
}

