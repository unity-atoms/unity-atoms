using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Code found at: https://github.com/Maligan/unity-subassets-drag-and-drop/blob/master/SubAssetDragAndDrop.cs and modified.
    /// </summary>
    [InitializeOnLoad]
    public static class SubAssetDragAndDrop
    {
        static SubAssetDragAndDrop()
        {
            EditorApplication.projectWindowItemOnGUI += OnProjectWindowItemOnGUI;
        }

        private static void OnProjectWindowItemOnGUI(string guid, Rect selectionRect)
        {
            // Break - key modifier is not pressed
            var activated = Event.current.alt;
            if (activated == false)
                return;

            // Break - OnGUI() call not for mouse target
            var within = selectionRect.Contains(Event.current.mousePosition);
            if (within == false)
                return;

            // Break - destination match one of sources 
            var target = AssetDatabase.GUIDToAssetPath(guid);
            var targetInSources = Array.IndexOf(DragAndDrop.paths, target) != -1;
            if (targetInSources)
                return;

            // Break - unity default moving
            var targetIsFolder = AssetDatabase.IsValidFolder(target);
            if (targetIsFolder)
            {
                foreach (var asset in DragAndDrop.objectReferences)
                {
                    if (AssetDatabase.IsMainAsset(asset))
                        return;
                }
            }
                

            // Break - there is Unity restriction to use GameObjects as SubAssets
            foreach (var obj in DragAndDrop.objectReferences)
            {
                if (obj is GameObject)
                    return;
            }

            if (Event.current.type == EventType.DragUpdated)
            {
                DragAndDrop.visualMode = DragAndDropVisualMode.Move;
                Event.current.Use();
            }
            else if (Event.current.type == EventType.DragPerform)
            {
                Move(DragAndDrop.objectReferences, target);
                DragAndDrop.AcceptDrag();
                Event.current.Use();
            }
        }

        private static void Move(IEnumerable<UnityEngine.Object> sources, string destinationPath)
        {
            foreach (var source in sources)
            {
                var sourcePath = AssetDatabase.GetAssetPath(source);
                var sourceIsMain = AssetDatabase.IsMainAsset(source);
                var sourceAssets = new List<UnityEngine.Object>() { source };
                if (sourceIsMain)
                {
                    sourceAssets.AddRange(AssetDatabase.LoadAllAssetRepresentationsAtPath(sourcePath));
                }

                // Peform move assets from source file to destination
                foreach (var asset in sourceAssets)
                {
                    MoveAsset(asset, destinationPath);
                }

                // Remove asset file if it is empty now
                if (sourceIsMain)
                {
                    AssetDatabase.DeleteAsset(sourcePath);
                }
            }

            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }

        private static void MoveAsset(UnityEngine.Object asset, string destinationPath)
        {
            // Find hidden references (before source move)
            var assetRefs = GetHiddenReferences(asset);

            // Move asset
            var destinationIsFolder = AssetDatabase.IsValidFolder(destinationPath);
            if (destinationIsFolder)
            {
                var assetName = asset.name + "." + GetFileExtention(asset);
                var assetPath = Path.Combine(destinationPath, assetName);
                var assetUniquePath = AssetDatabase.GenerateUniqueAssetPath(assetPath);

                AssetDatabase.RemoveObjectFromAsset(asset);
                AssetDatabase.CreateAsset(asset, assetUniquePath);
            }
            else
            {
                AssetDatabase.RemoveObjectFromAsset(asset);
                AssetDatabase.AddObjectToAsset(asset, destinationPath);
            }

            // Move attached hidden references
            foreach (var reference in assetRefs)
            {
                AssetDatabase.RemoveObjectFromAsset(reference);
                AssetDatabase.AddObjectToAsset(reference, asset);
            }
        }

        private static List<UnityEngine.Object> GetHiddenReferences(
            UnityEngine.Object asset,
            string refsPath = null,
            List<UnityEngine.Object> refs = null)
        {
            if (refsPath == null)
            {
                refsPath = AssetDatabase.GetAssetPath(asset);
            }

            if (refs == null)
            {
                refs = new List<UnityEngine.Object>();
            }

            var iterator = new SerializedObject(asset).GetIterator();
            while (iterator.Next(true))
            {
                if (iterator.propertyType == SerializedPropertyType.ObjectReference)
                {
                    var obj = iterator.objectReferenceValue;
                    if (obj != null && (obj.hideFlags & HideFlags.HideInHierarchy) != 0)
                    {
                        if (refs.IndexOf(obj) == -1 && AssetDatabase.GetAssetPath(obj) == refsPath)
                        {
                            refs.Add(obj);
                            GetHiddenReferences(obj, refsPath, refs);
                        }
                    }
                }
            }

            return refs;
        }

        /// Thanks to mob-sakai (https://github.com/mob-sakai/SubAssetEditor) for full mapping list
        private static string GetFileExtention(UnityEngine.Object obj)
        {
            if (obj is AnimationClip)
                return "anim";
            else if (obj is UnityEditor.Animations.AnimatorController)
                return "controller";
            else if (obj is AnimatorOverrideController)
                return "overrideController";
            else if (obj is Material)
                return "mat";
            else if (obj is Texture)
                return "png";
            else if (obj is ComputeShader)
                return "compute";
            else if (obj is Shader)
                return "shader";
            else if (obj is Cubemap)
                return "cubemap";
            else if (obj is Flare)
                return "flare";
            else if (obj is ShaderVariantCollection)
                return "shadervariants";
            else if (obj is LightmapParameters)
                return "giparams";
            else if (obj is GUISkin)
                return "guiskin";
            else if (obj is PhysicMaterial)
                return "physicMaterial";
            else if (obj is PhysicsMaterial2D)
                return "physicsMaterial2D";
            else if (obj is UnityEngine.Audio.AudioMixer)
                return "mixer";
            else if (obj is UnityEngine.U2D.SpriteAtlas)
                return "spriteatlas";
            else if (obj is TextAsset)
                return "txt";
            else if (obj is GameObject)
                return "prefab";
            else if (obj is ScriptableObject)
                return "asset";

            return null;
        }
    }
}
