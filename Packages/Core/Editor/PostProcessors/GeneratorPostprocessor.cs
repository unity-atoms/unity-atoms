using System;
using UnityEditor;
using UnityEditor.Compilation;

namespace UnityAtoms.Editor
{
    public class GeneratorPostprocessor : AssetPostprocessor
    {
        private static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
        {
            if (Array.Exists(importedAssets, importedAsset => AssetDatabase.GetMainAssetTypeAtPath(importedAsset).IsSubclassOf(typeof(Generator))))
            {
                CompilationPipeline.RequestScriptCompilation();
            }
        }
    }
}
