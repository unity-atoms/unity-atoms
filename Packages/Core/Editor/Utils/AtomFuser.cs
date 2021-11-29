using System.IO;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    public static class AtomFuser
    {
        public static bool IsValidFuse(BaseAtom ab)
        {
            var variablePath = AssetDatabase.GetAssetOrScenePath(ab);
            var destinationPath = variablePath.Replace($"/{ab.name}.asset", "");
            if (destinationPath.EndsWith(".asset"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Object FindSubAsset(Object parent, Object assetToFind)
        {
            Object[] objs = AssetDatabase.LoadAllAssetsAtPath(AssetDatabase.GetAssetPath(parent));
            foreach (var item in objs)
            {
                if (assetToFind.Equals(item))
                {
                    return item;
                }
            }
            return default;
        }

        public static bool IsFused(SerializedProperty property, BaseAtom ab)
        {
            if (FindSubAsset(ab, property.objectReferenceValue) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void FuseAtom(SerializedProperty property, BaseAtom ab)
        {
            var sourceIsMain = AssetDatabase.IsMainAsset(property.objectReferenceValue);
            var sourcePath = AssetDatabase.GetAssetPath(property.objectReferenceValue);
            AssetDatabase.RemoveObjectFromAsset(property.objectReferenceValue);
            AssetDatabase.AddObjectToAsset(property.objectReferenceValue, ab);

            if (sourceIsMain)
            {
                AssetDatabase.DeleteAsset(sourcePath);
            }

            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }

        public static void DiffuseAtom(SerializedProperty property, BaseAtom ab)
        {
            var variablePath = AssetDatabase.GetAssetOrScenePath(ab);
            var destinationPath = variablePath.Replace($"/{ab.name}.asset", "");
            var assetName = property.objectReferenceValue.name + ".asset";
            var assetPath = Path.Combine(destinationPath, assetName);
            var assetUniquePath = AssetDatabase.GenerateUniqueAssetPath(assetPath);
            AssetDatabase.RemoveObjectFromAsset(property.objectReferenceValue);
            AssetDatabase.CreateAsset(property.objectReferenceValue, assetUniquePath);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }
    }
}
