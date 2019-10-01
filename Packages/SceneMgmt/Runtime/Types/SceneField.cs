using System;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
using Debug = UnityEngine.Debug;
using Object = UnityEngine.Object;

namespace UnityAtoms.SceneMgmt
{
    [Serializable]
    public struct SceneField : ISerializationCallbackReceiver
    {
        [SerializeField] private Object _sceneAsset;
        [SerializeField] private string _sceneName;
        [SerializeField] private string _scenePath;
        [SerializeField] private int _buildIndex;

        public string SceneName { get { return _sceneName; } }
        public string ScenePath { get { return _scenePath; } }
        public int BuildIndex { get { return _buildIndex; } }

        // makes it work with the existing Unity methods (LoadLevel/LoadScene)
        public static implicit operator string(SceneField sceneField) { return sceneField.SceneName; }


        public int callbackOrder { get; }

        void Validate()
        {
#if UNITY_EDITOR
            if (!EditorApplication.isPlayingOrWillChangePlaymode
            || EditorApplication.isCompiling
            ) return;

            if (_sceneAsset == null)
            {
                _scenePath = "";
                _buildIndex = -1;
                _sceneName = "";
                return;
            }
            _buildIndex = SceneUtility.GetBuildIndexByScenePath(_scenePath);
            if (_sceneAsset != null && _buildIndex == -1)
            {
                /* Sadly its not easy to find which gameobject/component has this SceneField, at least not at this point */
                Debug.LogError($"A scene [{_sceneName}] you used as reference has no valid build Index", _sceneAsset);
                // Exit play mode - might be a bit too harsh?
#if UNITY_2019_1_OR_NEWER
                EditorApplication.ExitPlaymode();
#else
                EditorApplication.isPlaying = false;
#endif
            }
#endif
        }

        public void OnBeforeSerialize() { Validate(); }

        public void OnAfterDeserialize() { }
    }
}
