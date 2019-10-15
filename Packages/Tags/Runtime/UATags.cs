using System.Collections.Generic;
using System.Linq;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

namespace UnityAtoms.Tags
{
    /// <summary>
    /// A MonoBehaviour that adds tags the Unity Atoms way to a GameObject.
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    [AddComponentMenu("Unity Atoms/Tags")]
    public sealed class UATags : MonoBehaviour, ISerializationCallbackReceiver
    {
        /// <summary>
        /// Get the tags associated with this GameObject as `StringConstants` in a `ReadOnlyList&lt;T&gt;`.
        /// </summary>
        /// <value>The tags associated with this GameObject as `StringConstants` in a `ReadOnlyList&lt;T&gt;`.</value>
        public ReadOnlyList<StringConstant> Tags { get; private set; }

        [SerializeField]
        private List<StringConstant> _tags = new List<StringConstant>();

        private SortedList<string, StringConstant> _sortedTags = new SortedList<string, StringConstant>();

        private static readonly Dictionary<string, List<GameObject>> TaggedGameObjects
            = new Dictionary<string, List<GameObject>>();

        private static readonly Dictionary<GameObject, UATags> TagInstances
            = new Dictionary<GameObject, UATags>();


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

        #region Lifecycles

        private void Awake()
        {
            Tags = new ReadOnlyList<StringConstant>(_sortedTags.Values);
        }

        private void OnEnable()
        {
            if (!TagInstances.ContainsKey(gameObject)) TagInstances.Add(gameObject, this);
            for (var i = 0; i < Tags.Count; i++)
            {
                var stringConstant = Tags[i];
                if (stringConstant == null) continue;
                var tag = stringConstant.Value;
                if (!TaggedGameObjects.ContainsKey(tag)) TaggedGameObjects.Add(tag, new List<GameObject>());
                TaggedGameObjects[tag].Add(gameObject);
            }
        }

        private void OnDisable()
        {
            if (TagInstances.ContainsKey(gameObject)) TagInstances.Remove(gameObject);
            for (var i = 0; i < Tags.Count; i++)
            {
                var stringConstant = Tags[i];
                if (stringConstant == null) continue;
                var tag = stringConstant.Value;
                if (TaggedGameObjects.ContainsKey(tag)) TaggedGameObjects[tag].Remove(gameObject);
            }
        }

        #endregion

        /// <summary>
        /// Check if the tag provided is associated with this `GameObject`.
        /// </summary>
        /// <param name="tag"></param>
        /// <returns>`true` if the tag exists, otherwise `false`.</returns>
        public bool HasTag(string tag)
        {
            if (tag == null) return false;
            return _sortedTags.ContainsKey(tag);
        }

        /// <summary>
        /// Add a tag to this `GameObject`.
        /// </summary>
        /// <param name="tag">The tag to add as a `StringContant`.</param>
        public void AddTag(StringConstant tag)
        {
            if (tag == null || tag.Value == null) return;
            if (_sortedTags.ContainsKey(tag.Value)) return;
            _sortedTags.Add(tag.Value, tag);

            Tags = new ReadOnlyList<StringConstant>(_sortedTags.Values);

            // Update static accessors:
            if (!TaggedGameObjects.ContainsKey(tag.Value)) TaggedGameObjects.Add(tag.Value, new List<GameObject>());
            TaggedGameObjects[tag.Value].Add(this.gameObject);
        }

        /// <summary>
        /// Remove a tag from this `GameObject`.
        /// </summary>
        /// <param name="tag">The tag to remove as a `string`</param>
        public void RemoveTag(string tag)
        {
            if (tag == null) return;
            if (_sortedTags.ContainsKey(tag)) return;
            _sortedTags.Remove(tag);

            Tags = new ReadOnlyList<StringConstant>(_sortedTags.Values);

            // Update static accessors:
            if (!TaggedGameObjects.ContainsKey(tag)) return; // this should never happen
            TaggedGameObjects[tag].Remove(this.gameObject);
        }

        /// <summary>
        /// Find first `GameObject` that has the tag provided.
        /// </summary>
        /// <param name="tag">The tag that the `GameObject` that you search for will have.</param>
        /// <returns>The first `GameObject` with the provided tag found. If no `GameObject`is found, it returns `null`.</returns>
        public static GameObject FindByTag(string tag)
        {
            if (!TaggedGameObjects.ContainsKey(tag)) return null;
            return TaggedGameObjects[tag][0];
        }

        /// <summary>
        /// Find all `GameObject`s that have the tag provided.
        /// </summary>
        /// <param name="tag">The tag that the `GameObject`s that you search for will have.</param>
        /// <returns>An array of `GameObject`s with the provided tag. If not found it returns `null`.</returns>
        public static GameObject[] FindAllByTag(string tag)
        {
            if (!TaggedGameObjects.ContainsKey(tag)) return null;
            return TaggedGameObjects[tag].ToArray();
        }

        /// <summary>
        /// Find all `GameObject`s that have the tag provided. Mutates the output `List&lt;GameObject&gt;` and adds the `GameObject`s found to it.
        /// </summary>
        /// <param name="tag">The tag that the `GameObject`s that you search for will have.</param>
        /// <param name="output">A `List&lt;GameObject&gt;` that this method will clear and add the `GameObject`s found to.</param>
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
        /// A faster alternative to `gameObject.GetComponen&lt;UATags&gt;()`.
        /// </summary>
        /// <returns>
        /// Returns the `UATags` component. Returns `null` if the `GameObject` does not have a `UATags` component or if the `GameObject` is disabled.
        /// </returns>
        public static UATags GetTagsForGameObject(GameObject go)
        {
            if (!TagInstances.ContainsKey(go)) return null;
            return TagInstances[go];
        }

        /// <summary>
        /// Retrieves all tags for a given `GameObject`. A faster alternative to `gameObject.GetComponen&lt;UATags&gt;().Tags`.
        /// </summary>
        /// <param name="go">The `GameObject` to check for tags.</param>
        /// <returns>
        /// A `ReadOnlyList&lt;T&gt;` of tags stored as `StringContant`s. Returns `null` if the `GameObject` does not have any tags or if the `GameObject` is disabled.
        /// </returns>
        public static ReadOnlyList<StringConstant> GetTags(GameObject go)
        {
            if (!TagInstances.ContainsKey(go)) return null;
            var tags = TagInstances[go];
            return tags.Tags;
        }
    }
}
