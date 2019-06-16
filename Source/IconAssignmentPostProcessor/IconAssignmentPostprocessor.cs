using UnityEditor;

namespace UnityAtoms
{
    public class IconAssignmentPostprocessor : AssetPostprocessor
    {
        static AtomsIconAssignmentProcessor _iconAssignment = new AtomsIconAssignmentProcessor();

        static IconAssignmentPostprocessor()
        {
            _iconAssignment.ReloadIconsFromSettings();
        }

        static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
        {
            _iconAssignment.Process(importedAssets);
        }
    }
}
