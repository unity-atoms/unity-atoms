using System;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
using Debug = UnityEngine.Debug;
using Object = UnityEngine.Object;

namespace UnityAtoms {
    [Serializable]
    public struct SceneField : ISerializationCallbackReceiver
    {
        [SerializeField] private Object sceneAsset;
        [SerializeField] private string sceneName;
        [SerializeField] private string scenePath;
        [SerializeField] private int buildIndex;

        public string SceneName { get { return sceneName; } }
        public string ScenePath { get { return scenePath; } }
        public int BuildIndex { get { return buildIndex; } }

        // makes it work with the existing Unity methods (LoadLevel/LoadScene)
        public static implicit operator string(SceneField sceneField) { return sceneField.SceneName; }


        public int callbackOrder { get; }

        void Validate()
        {
#if UNITY_EDITOR
            if(! EditorApplication.isPlayingOrWillChangePlaymode
            || EditorApplication.isCompiling
            ) return;

            if (sceneAsset == null)
            {
                scenePath = "";
                buildIndex = -1;
                sceneName = "";
                return;
            }
            buildIndex = SceneUtility.GetBuildIndexByScenePath(scenePath);
            if (sceneAsset != null && buildIndex == -1)
            {
                /* Sadly its not easy to find which gameobject/component has this SceneField, at least not at this point */
                Debug.LogError($"A scene [{sceneName}] you used as reference has no valid build Index", sceneAsset);
                EditorApplication.ExitPlaymode(); // this might be a bit hard, but at least its instant pretty fast

            }
    #endif
        }

        public void OnBeforeSerialize() { Validate(); }

        public void OnAfterDeserialize() { }
    }
}
