#if UNITY_2019_1_OR_NEWER
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor;
#if USE_ADDRESSABLES
using UnityEditor.AddressableAssets;
using UnityEditor.AddressableAssets.Settings;
#endif

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Custom editor for Events. Adds the possiblity to raise an Event from Unity's Inspector.
    /// </summary>
    /// <typeparam name="T">The type of this event..</typeparam>
    /// <typeparam name="E">Event of type T.</typeparam>
    public abstract class AtomEventEditor<T, E> : UnityEditor.Editor
        where E : AtomEvent<T>
    {
        public override VisualElement CreateInspectorGUI()
        {
            var root = new VisualElement();

            #if USE_ADDRESSABLES
            IMGUIContainer addressablesWarning = new IMGUIContainer(AddressableWarningHandler);
            root.Add(addressablesWarning);
            #endif

            IMGUIContainer defaultInspector = new IMGUIContainer(() => DrawDefaultInspector());
            root.Add(defaultInspector);

            E atomEvent = target as E;

            var runtimeWrapper = new VisualElement();
            runtimeWrapper.SetEnabled(Application.isPlaying);
            runtimeWrapper.Add(new Button(() =>
            {
                atomEvent.Raise(atomEvent.InspectorRaiseValue);
            })
            {
                text = "Raise"
            });
            root.Add(runtimeWrapper);

#if !UNITY_ATOMS_GENERATE_DOCS
            StackTraceEditor.RenderStackTrace(root, atomEvent.GetInstanceID());
#endif

            return root;
        }

        private void AddressableWarningHandler()
        {
            AddressableAssetSettings settings = AddressableAssetSettingsDefaultObject.Settings;
            string assetPath = AssetDatabase.GetAssetPath(serializedObject.targetObject);
            string guid = AssetDatabase.AssetPathToGUID(assetPath);
            AddressableAssetEntry entry = settings.FindAssetEntry(guid);

            if (entry != null)
            {
                EditorGUILayout.HelpBox("This asset is marked as addressable, his lifetime will not be managed by Unity Atoms.\nSee more in documentation", MessageType.Warning);
            }
            else
            {
                EditorGUILayout.HelpBox("Addressables is installed, careful, Unity Atoms might be unable to manage the asset.\nSee more in documentation", MessageType.Info);
            }
            EditorGUILayout.Space();
        }
    }
}
#endif
