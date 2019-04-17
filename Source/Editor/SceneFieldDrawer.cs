using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityAtoms
{
    [CustomPropertyDrawer(typeof(SceneField))]
    public class SceneFieldDrawer : PropertyDrawer
    {
        private static class HelperMethods
        {
            public static Rect SnipRectH(Rect rect, float range)
            {
                if (range == 0) return new Rect(rect);
                if (range > 0)
                {
                    return new Rect(rect.x, rect.y, range, rect.height);
                }

                return new Rect(rect.x + rect.width + range, rect.y, -range, rect.height);
            }

            public static Rect SnipRectH(Rect rect, float range, out Rect rest)
            {
                if (range == 0) rest = new Rect();
                if (range > 0)
                {
                    rest = new Rect(rect.x + range, rect.y, rect.width - range, rect.height);
                } else
                {
                    rest = new Rect(rect.x, rect.y, rect.width + range, rect.height);
                }

                return SnipRectH(rect, range);
            }

            public static Rect SnipRectV(Rect rect, float range)
            {
                if (range == 0) return new Rect(rect);
                if (range > 0)
                {
                    return new Rect(rect.x, rect.y, rect.width, range);
                }

                return new Rect(rect.x, rect.y + rect.height + range, rect.width, -range);
            }

            public static Rect SnipRectV(Rect rect, float range, out Rect rest)
            {
                if (range == 0) rest = new Rect();
                if (range > 0)
                {
                    rest = new Rect(rect.x, rect.y + range, rect.width, rect.height - range);
                } else
                {
                    rest = new Rect(rect.x, rect.y, rect.width, rect.height + range);
                }

                return SnipRectV(rect, range);
            }
        }

        private bool HasValidBuildIndex(SerializedProperty property)
        {
            var scene = property.FindPropertyRelative("sceneAsset")?.objectReferenceValue;
            if (scene == null) return true;
            var scenePath = AssetDatabase.GetAssetPath(scene);
            var buildIndex = SceneUtility.GetBuildIndexByScenePath(scenePath);
            return buildIndex != -1;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            OnPropertyGUI(position, property, label);
            EditorGUI.EndProperty();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            if(HasValidBuildIndex(property)) return base.GetPropertyHeight(property, label);
            return base.GetPropertyHeight(property, label) * 2 + 5;
        }

        private void OnPropertyGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            Rect lower;
            Rect buttonRect = new Rect();
            var scene = property.FindPropertyRelative("sceneAsset")?.objectReferenceValue;

            if(scene == null){ // update values cause the build index could've changed
                property.FindPropertyRelative("sceneName").stringValue = "";
                property.FindPropertyRelative("scenePath").stringValue = "";
                property.FindPropertyRelative("buildIndex").intValue = -1;
            }

            position = HelperMethods.SnipRectV(position, EditorGUIUtility.singleLineHeight, out lower);
            if (HasValidBuildIndex(property)){
                if(scene != null){ // update values cause the build index could've changed
                    property.FindPropertyRelative("sceneName").stringValue = scene.name;
                    property.FindPropertyRelative("scenePath").stringValue = AssetDatabase.GetAssetPath(scene);
                    property.FindPropertyRelative("buildIndex").intValue = SceneUtility.GetBuildIndexByScenePath(
                        property.FindPropertyRelative("scenePath").stringValue
                    );
                }
            } else
            {
                position = HelperMethods.SnipRectH(position, position.width - 70, out buttonRect);
                property.FindPropertyRelative("buildIndex").intValue = -1;
            }

            // int buildIndex = SceneUtility.GetBuildIndexByScenePath(property.FindPropertyRelative("scenePath").stringValue);
            SceneAsset sceneAsset = scene as SceneAsset;
            // RENDER LABEL:
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

            // RENDER OBJECT FIELD:
            EditorGUI.BeginChangeCheck();
            scene = EditorGUI.ObjectField(position, scene, typeof(SceneAsset), false);
            if (EditorGUI.EndChangeCheck())
            {
                property.FindPropertyRelative("sceneAsset").objectReferenceValue = scene;
                sceneAsset = scene as SceneAsset;
                if (sceneAsset != null)
                {
                    property.FindPropertyRelative("sceneName").stringValue = scene.name;
                    property.FindPropertyRelative("scenePath").stringValue = AssetDatabase.GetAssetPath(scene);
                    property.FindPropertyRelative("buildIndex").intValue = SceneUtility.GetBuildIndexByScenePath(
                        property.FindPropertyRelative("scenePath").stringValue
                    );
                }
            }

            if (property.FindPropertyRelative("buildIndex").intValue != -1) return;

            // OPTIONAL: RENDER BUTTON
            if (scene != null && scene is SceneAsset)
            {
                EditorGUI.HelpBox(lower, "Scene is not added in the build settings", MessageType.Warning);
                if (GUI.Button(buttonRect, "Fix Now"))
                {
                    AddSceneToBuildSettings(sceneAsset);
                }
            }
        }

        private void AddSceneToBuildSettings(SceneAsset sceneAsset)
        {
            var scenePath = AssetDatabase.GetAssetPath(sceneAsset);
            // var assetsIndex = scenePath.IndexOf("Assets", StringComparison.Ordinal) + 7;
            // var extensionIndex = scenePath.LastIndexOf(".unity", StringComparison.Ordinal);
            // scenePath = scenePath.Substring(assetsIndex, extensionIndex - assetsIndex);

            var scenes = EditorBuildSettings.scenes.ToList();
            scenes.Add(new EditorBuildSettingsScene(scenePath, true));

            EditorBuildSettings.scenes = scenes.ToArray();
        }
    }
}
