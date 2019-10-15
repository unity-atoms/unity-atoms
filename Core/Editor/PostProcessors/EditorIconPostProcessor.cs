using System.IO;
using System.Linq;
using System.Collections.Generic;
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Postprocessor that processes all scripts using the EditorIcon attribute and assigns the matching icon guid (matching the icon query name) to the script's meta. It's a very simple solution (and very hacky), but works really great.
    /// </summary>
    public class EditorIconPostProcessor : AssetPostprocessor
    {
        /// <summary>
        /// Called when new assets are imported, deleted or moved.
        /// </summary>
        /// <param name="importedAssets">Imported assets.</param>
        /// <param name="deletedAssets">Deleted assets.</param>
        /// <param name="movedAssets">Moved assets.</param>
        /// <param name="movedFromAssetPaths">Moved from asset paths.</param>
        static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
        {
            var metaChangedForAssets = new List<string>();
            foreach (string assetPath in importedAssets)
            {
                // NOTE: Below is not working since it's not compiled at this point
                // We therefore need to do some string manipulations...
                // var script = AssetDatabase.LoadAssetAtPath<MonoScript>(assetPath);
                // var type = script?.GetClass();

                var metaPath = $"{assetPath}.meta";
                if (File.Exists(assetPath) && File.Exists(metaPath) && assetPath.EndsWith(".cs"))
                {
                    // Hack, hack, hack away....
                    var scriptText = File.ReadAllText(assetPath);
                    var containsEditorIconAttr = scriptText.Contains("[EditorIcon(");

                    if (containsEditorIconAttr)
                    {
                        // Extract icon name from attribute
                        // We are assuming that template strings are not used
                        var attrIconNameStartIndex = scriptText.IndexOf("[EditorIcon(") + 13;
                        var attrIconNameLength = scriptText.IndexOf("\")", attrIconNameStartIndex) - attrIconNameStartIndex;
                        var iconName = scriptText.Substring(attrIconNameStartIndex, attrIconNameLength);

                        // Find guid based on icon name from attr
                        var iconGuids = AssetDatabase.FindAssets($"{iconName} t:texture2D");
                        var iconGuidsList = iconGuids.ToList();
                        var guid = iconGuidsList.FirstOrDefault();

                        if (!string.IsNullOrEmpty(guid))
                        {
                            // Read meta for script
                            var scriptMetaTextLines = File.ReadAllLines(metaPath);
                            var metaIconLine = $"icon: {{fileID: 2800000, guid: {guid}, type: 3}}";
                            for (var i = 0; i < scriptMetaTextLines.Length; ++i)
                            {
                                var line = scriptMetaTextLines[i];
                                // Find icon line
                                if (line.Contains("icon: ") && !line.Contains(metaIconLine))
                                {
                                    var indexIconKeyName = line.IndexOf("icon: ");
                                    var indexAfterClosingBrace = line.IndexOf("}", indexIconKeyName) + 1;
                                    var newLine = line.Replace(line.Substring(indexIconKeyName, indexAfterClosingBrace - indexIconKeyName), metaIconLine);
                                    scriptMetaTextLines[i] = newLine;
                                    File.WriteAllLines(metaPath, scriptMetaTextLines);
                                    metaChangedForAssets.Add(assetPath);
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            // We need to reimport all assets where the meta was changed
            if (metaChangedForAssets.Count > 0)
            {
                foreach (var assetPath in metaChangedForAssets)
                {
                    AssetDatabase.ImportAsset(assetPath);
                }
            }
        }
    }
}
