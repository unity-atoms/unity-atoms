using UnityEngine;
using UnityEditor;
using System.IO;

namespace UnityAtoms.Editor
{
    [CustomEditor(typeof(DefaultAsset))]
    public class AtomFolderEditor : UnityEditor.Editor
    {
        protected override void OnHeaderGUI()
        {
            base.OnHeaderGUI();

            if (!Directory.Exists(AssetDatabase.GetAssetPath(target))) return;
            if (!target.name.ToLowerInvariant().Contains("atom")) return;

            GUILayout.Label("UNITY ATOMS", (GUIStyle) "AC BoldHeader", GUILayout.ExpandWidth(true));

            if (GUILayout.Button("Add Generator", (GUIStyle) "LargeButton"))
            {
                var asset = CreateInstance<AtomGenerator>();
                var newPath = Path.Combine(
                    AssetDatabase.GetAssetPath(target),
                    "New Atom Type.asset"
                );
                newPath = AssetDatabase.GenerateUniqueAssetPath(newPath);
                Debug.Log(newPath);
                AssetDatabase.CreateAsset(asset, newPath);
                AssetDatabase.ImportAsset(newPath);
            }
        }
    }
}
