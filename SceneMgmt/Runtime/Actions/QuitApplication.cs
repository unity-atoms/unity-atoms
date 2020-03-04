using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Action to quit the application.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Scene Management/Quit Application")]
    public sealed class QuitApplication : VoidAction
    {
        /// <summary>
        /// Do quit the apllication.
        /// </summary>
        public override void Do()
        {
            Application.Quit();
        }
    }
}

