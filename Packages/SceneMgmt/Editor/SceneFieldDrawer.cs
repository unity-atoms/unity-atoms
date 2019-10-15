using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityAtoms.SceneMgmt.Editor
{
    /// <summary>
    /// Customer property drawer for `SceneField`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SceneField))]
    public class SceneFieldDrawer : PropertyDrawer
    {
        private bool HasValidBuildIndex(SerializedProperty property)
        {
            var scene = property.FindPropertyRelative("_sceneAsset")?.objectReferenceValue;
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
            if (HasValidBuildIndex(property)) return base.GetPropertyHeight(property, label);
            return base.GetPropertyHeight(property, label) * 2 + 5;
        }

        private void OnPropertyGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            Rect lower;
            Rect buttonRect = new Rect();
            var scene = property.FindPropertyRelative("_sceneAsset")?.objectReferenceValue;

            if (scene == null)
            {
                // Update values cause the build index could've changed
                property.FindPropertyRelative("_sceneName").stringValue = "";
                property.FindPropertyRelative("_scenePath").stringValue = "";
                property.FindPropertyRelative("_buildIndex").intValue = -1;
            }

            position = IMGUIUtils.SnipRectV(position, EditorGUIUtility.singleLineHeight, out lower, 2f);
            if (HasValidBuildIndex(property))
            {
                if (scene != null)
                {
                    // Update values cause the build index could've changed
                    property.FindPropertyRelative("_sceneName").stringValue = scene.name;
                    property.FindPropertyRelative("_scenePath").stringValue = AssetDatabase.GetAssetPath(scene);
                    property.FindPropertyRelative("_buildIndex").intValue = SceneUtility.GetBuildIndexByScenePath(
                        property.FindPropertyRelative("_scenePath").stringValue
                    );
                }
            }
            else
            {
                position = IMGUIUtils.SnipRectH(position, position.width - 70, out buttonRect, 6f);
                property.FindPropertyRelative("_buildIndex").intValue = -1;
            }

            SceneAsset sceneAsset = scene as SceneAsset;
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

            EditorGUI.BeginChangeCheck();
            scene = EditorGUI.ObjectField(position, scene, typeof(SceneAsset), false);
            if (EditorGUI.EndChangeCheck())
            {
                property.FindPropertyRelative("_sceneAsset").objectReferenceValue = scene;
                sceneAsset = scene as SceneAsset;
                if (sceneAsset != null)
                {
                    property.FindPropertyRelative("_sceneName").stringValue = scene.name;
                    property.FindPropertyRelative("_scenePath").stringValue = AssetDatabase.GetAssetPath(scene);
                    property.FindPropertyRelative("_buildIndex").intValue = SceneUtility.GetBuildIndexByScenePath(
                        property.FindPropertyRelative("_scenePath").stringValue
                    );
                }
            }

            if (property.FindPropertyRelative("_buildIndex").intValue != -1) return;

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

            var scenes = EditorBuildSettings.scenes.ToList();
            scenes.Add(new EditorBuildSettingsScene(scenePath, true));

            EditorBuildSettings.scenes = scenes.ToArray();
        }
    }
}
