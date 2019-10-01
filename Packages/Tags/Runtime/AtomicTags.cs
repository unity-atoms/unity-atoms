using System.Collections.Generic;
using System.Linq;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

namespace UnityAtoms.Tags
{
    [AddComponentMenu("Unity Atoms/Tags/Atomic Tags")]
    public sealed class AtomicTags : MonoBehaviour, ISerializationCallbackReceiver
    {
        public ReadOnlyList<StringConstant> Tags { get; private set; }

        private SortedList<string, StringConstant> _sortedTags = new SortedList<string, StringConstant>();

        private static readonly Dictionary<string, List<GameObject>> TaggedGameObjects
            = new Dictionary<string, List<GameObject>>();

        private static readonly Dictionary<GameObject, AtomicTags> AtomicTagInstances
            = new Dictionary<GameObject, AtomicTags>();

        public List<StringConstant> _tags = new List<StringConstant>();

        #region Serialization

        public void OnBeforeSerialize()
        {
#if UNITY_EDITOR
            if (!EditorApplication.isPlaying
            && !EditorApplication.isUpdating
            && !EditorApplication.isCompiling) return;
#endif
            _tags.Clear();
            foreach (var kvp in _sortedTags)
            {
                _tags.Add(kvp.Value);
            }
        }

        public void OnAfterDeserialize()
        {
            _sortedTags = new SortedList<string, StringConstant>();

            for (int i = 0; i != _tags.Count; i++)
            {
                if (_tags[i] == null || _tags[i].Value == null) continue;
                if (_sortedTags.ContainsKey(_tags[i].Value)) continue;
                _sortedTags.Add(_tags[i].Value, _tags[i]);
            }
        }
        #endregion

#if UNITY_EDITOR
        private void OnValidate()
        {
            OnAfterDeserialize(); // removes double values and nulls
            _tags = _sortedTags.Values.ToList();

            // this null value is just for easier editing and could also be archived with an custom inspector
            if (!EditorApplication.isPlaying) { _tags.Add(null); }
        }
#endif

        #region Lifecycle

        private void Awake()
        {
            Tags = new ReadOnlyList<StringConstant>(_sortedTags.Values);
        }

        private void OnEnable()
        {
            if (!AtomicTagInstances.ContainsKey(gameObject)) AtomicTagInstances.Add(gameObject, this);
            for (var i = 0; i < Tags.Count; i++)
            {
                var stringConstant = Tags[i];
                if (stringConstant == null) continue;
                var atomicTag = stringConstant.Value;
                if (!TaggedGameObjects.ContainsKey(atomicTag)) TaggedGameObjects.Add(atomicTag, new List<GameObject>());
                TaggedGameObjects[atomicTag].Add(gameObject);
            }
        }

        private void OnDisable()
        {
            if (AtomicTagInstances.ContainsKey(gameObject)) AtomicTagInstances.Remove(gameObject);
            for (var i = 0; i < Tags.Count; i++)
            {
                var stringConstant = Tags[i];
                if (stringConstant == null) continue;
                var atomicTag = stringConstant.Value;
                if (TaggedGameObjects.ContainsKey(atomicTag)) TaggedGameObjects[atomicTag].Remove(gameObject);
            }
        }

        #endregion

        public bool HasTag(string atomicTag)
        {
            if (atomicTag == null) return false;
            return _sortedTags.ContainsKey(atomicTag);
        }

        public void AddTag(StringConstant atomicTag)
        {
            if (atomicTag == null || atomicTag.Value == null) return;
            if (_sortedTags.ContainsKey(atomicTag.Value)) return;
            _sortedTags.Add(atomicTag.Value, atomicTag);

            Tags = new ReadOnlyList<StringConstant>(_sortedTags.Values);

            // Update static accessors:
            if (!TaggedGameObjects.ContainsKey(atomicTag.Value)) TaggedGameObjects.Add(atomicTag.Value, new List<GameObject>());
            TaggedGameObjects[atomicTag.Value].Add(this.gameObject);
        }

        public void RemoveTag(string atomicTag)
        {
            if (atomicTag == null) return;
            if (_sortedTags.ContainsKey(atomicTag)) return;
            _sortedTags.Remove(atomicTag);

            Tags = new ReadOnlyList<StringConstant>(_sortedTags.Values);

            // Update static accessors:
            if (!TaggedGameObjects.ContainsKey(atomicTag)) return; // this should never happen
            TaggedGameObjects[atomicTag].Remove(this.gameObject);
        }

        public static GameObject FindByTag(string tag)
        {
            if (!TaggedGameObjects.ContainsKey(tag)) return null;
            return TaggedGameObjects[tag][0];
        }

        public static GameObject[] FindAllByTag(string tag)
        {
            if (!TaggedGameObjects.ContainsKey(tag)) return null;
            return TaggedGameObjects[tag].ToArray();
        }

        public static void FindAllByTagNoAlloc(string tag, List<GameObject> output)
        {
            output.Clear();
            if (!TaggedGameObjects.ContainsKey(tag)) return;
            for (var i = 0; i < TaggedGameObjects[tag].Count; ++i)
            {
                output.Add(TaggedGameObjects[tag][i]);
            }
        }

        /// <summary>
        /// Faster alternative to go.GetComponent&lt;AtomicTags&gt;() since they are already cached in a dictionary
        /// </summary>
        /// <returns>
        /// - null if the GameObject does not have AtomicTags or they (or the GO) are disabled
        /// - the AtomicTag component
        /// </returns>
        public static AtomicTags GetForGameObject(GameObject go)
        {
            if (!AtomicTagInstances.ContainsKey(go)) return null;
            return AtomicTagInstances[go];
        }

        /// <summary>
        /// Retrieves all AtomicTags for a given GameObject
        /// </summary>
        /// <returns>
        /// - null if the GameObject does not have AtomicTags or they (or the GO) are disabled
        /// - an  readonly list of strings containing the tags
        /// - should be faster than go.GetComponent&lt;AtomicTags&gt;().tags
        /// </returns>
        public static ReadOnlyList<StringConstant> GetAtomicTags(GameObject go)
        {
            if (!AtomicTagInstances.ContainsKey(go)) return null;
            var atomicTags = AtomicTagInstances[go];
            return atomicTags.Tags;
        }
    }
}
