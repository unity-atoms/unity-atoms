using UnityEditor;

namespace UnityAtoms
{
    public class AttributeIconAssignmentPostprocessor : AssetPostprocessor
    {
        static AttributeIconAssignmentProcessor _iconAssignment = new AttributeIconAssignmentProcessor();

        static AttributeIconAssignmentPostprocessor()
        {
            _iconAssignment.ReloadIconsFromSettings();
        }

        static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
        {
            _iconAssignment.Process(importedAssets);
        }
    }
}
