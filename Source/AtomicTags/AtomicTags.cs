using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

namespace UnityAtoms
{
    public class AtomicTags : MonoBehaviour, ISerializationCallbackReceiver
    {

        public ReadOnlyList<StringConstant> Tags { get; private set; }
        private SortedList<string, StringConstant> sortedTags = new SortedList<string, StringConstant>();
        private static Dictionary<string, List<GameObject>> taggedGOs = new Dictionary<string, List<GameObject>>();
        private static Dictionary<GameObject, AtomicTags> instances = new Dictionary<GameObject, AtomicTags>();

        #region Serialization
        public List<StringConstant> _tags = new List<StringConstant>();
        public void OnBeforeSerialize()
        {
#if UNITY_EDITOR
            if(!EditorApplication.isPlaying
            && !EditorApplication.isUpdating
            && !EditorApplication.isCompiling) return;
#endif
            _tags.Clear();
            foreach (var kvp in sortedTags)
            {
                _tags.Add(kvp.Value);
            }
        }

        public void OnAfterDeserialize()
        {
            sortedTags = new SortedList<string, StringConstant>();

            for (int i = 0; i != _tags.Count; i++)
            {
                if (_tags[i] == null || _tags[i].Value == null) continue;
                if (sortedTags.ContainsKey(_tags[i].Value)) continue;
                sortedTags.Add(_tags[i].Value, _tags[i]);
            }
        }
        #endregion

        private void OnValidate()
        {
            OnAfterDeserialize(); // removes double values and nulls
            _tags = sortedTags.Values.ToList();
#if UNITY_EDITOR
            // this null value is just for easier editing and could also be archived with an custom inspector
            if(!EditorApplication.isPlaying){ _tags.Add(null); }
#endif
        }

        #region Lifecycle

        private void Awake()
        {
            Tags = new ReadOnlyList<StringConstant>(sortedTags.Values);
        }

        private void OnEnable()
        {
            if (!instances.ContainsKey(this.gameObject)) instances.Add(this.gameObject, this);
            foreach (var stringConstant in Tags)
            {
                if (stringConstant == null) continue;
                var tag = stringConstant.Value;
                if (!taggedGOs.ContainsKey(tag)) taggedGOs.Add(tag, new List<GameObject>());
                taggedGOs[tag].Add(this.gameObject);
            };
        }

        private void OnDisable()
        {
            if (instances.ContainsKey(this.gameObject)) instances.Remove(this.gameObject);
            foreach (var stringConstant in Tags)
            {
                if (stringConstant == null) continue;
                var tag = stringConstant.Value;
                if (taggedGOs.ContainsKey(tag)) taggedGOs[tag].Remove(this.gameObject);
            };
        }

        #endregion

        public bool HasTag(string tag)
        {
            if (tag == null) return false;
            return sortedTags.ContainsKey(tag);
        }

        public void AddTag(StringConstant tag)
        {
            if (tag == null || tag.Value == null) return;
            if (sortedTags.ContainsKey(tag.Value)) return;
            sortedTags.Add(tag.Value, tag);

            Tags = new ReadOnlyList<StringConstant>(sortedTags.Values);

            // Update static accessors:
            if (!taggedGOs.ContainsKey(tag.Value)) taggedGOs.Add(tag.Value, new List<GameObject>());
            taggedGOs[tag.Value].Add(this.gameObject);
        }

        public void RemoveTag(string tag)
        {
            if (tag == null) return;
            if (sortedTags.ContainsKey(tag)) return;
            sortedTags.Remove(tag);

            Tags = new ReadOnlyList<StringConstant>(sortedTags.Values);

            // Update static accessors:
            if (!taggedGOs.ContainsKey(tag)) return; // this should never happen
            taggedGOs[tag].Remove(this.gameObject);
        }

        public static GameObject FindByTag(string tag)
        {
            if (!taggedGOs.ContainsKey(tag)) return null;
            return taggedGOs[tag][0];
        }

        public static GameObject[] FindAllByTag(string tag)
        {
            if (!taggedGOs.ContainsKey(tag)) return null;
            return taggedGOs[tag].ToArray();
        }

        public static void FindAllByTagNoAlloc(string tag, List<GameObject> output)
        {
            output.Clear();
            if (!taggedGOs.ContainsKey(tag)) return;
            for (var i = 0; i < taggedGOs[tag].Count; ++i)
            {
                output.Add(taggedGOs[tag][i]);
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
            if (!instances.ContainsKey(go)) return null;
            return instances[go];
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
            if (!instances.ContainsKey(go)) return null;
            var atomicTags = instances[go];
            return atomicTags.Tags;
        }


    }
}
