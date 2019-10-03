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
    public struct SceneField : ISerializationCallbackReceiver, IEquatable<SceneField>
    {
        [SerializeField]
        private Object _sceneAsset;
        [SerializeField]
        private string _sceneName;
        [SerializeField]
        private string _scenePath;
        [SerializeField]
        private int _buildIndex;

        public string SceneName { get { return _sceneName; } }
        public string ScenePath { get { return _scenePath; } }
        public int BuildIndex { get { return _buildIndex; } }
        private Object SceneAsset { set { _sceneAsset = value; } } // NOTE: Needed in order to supress warning CS0649


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

        public bool Equals(SceneField other)
        {
            return (this == null && other == null) || (this != null && other != null && this._sceneName == other._sceneName);
        }

        public override bool Equals(object obj)
        {
            if (obj == null && this != null) return false;

            SceneField sf = (SceneField)obj;
            return this != null && sf != null && this.Equals(sf);
        }

        public override int GetHashCode()
        {
            if (this == null || this._sceneName == null) return 0;
            return this._sceneName.GetHashCode();
        }

        public static bool operator ==(SceneField sf1, SceneField sf2)
        {
            return (sf1 == null && sf2 == null) || (sf1 != null && sf1.Equals(sf2));
        }

        public static bool operator !=(SceneField sf1, SceneField sf2)
        {
            return (sf1 == null && sf2 != null) || (sf1 != null && !sf1.Equals(sf2));
        }
    }
}
