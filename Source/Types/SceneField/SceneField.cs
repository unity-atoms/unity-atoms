using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
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

        [Conditional("UNITY_EDITOR")]
        void Validate()
        {
            if (sceneAsset == null)
            {
                scenePath = "";
                buildIndex = -1;
                sceneName = "";
                return;
            }
            buildIndex = SceneUtility.GetBuildIndexByScenePath(scenePath);
            if (buildIndex == -1)
            {
                Debug.LogError($"A scene [{sceneName}] you used as reference has no valid build Index", sceneAsset);
            }
        }

        public void OnBeforeSerialize() { Validate(); }

        public void OnAfterDeserialize() { }
    }
}
