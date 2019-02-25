using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UnityAtoms
{
    public class AtomicTags : MonoBehaviour
    {
        [SerializeField] private List<StringConstant> tags = new List<StringConstant>();
        /// <summary>
        /// An Immutable, Sorted version of the Tags
        /// </summary>
        public StringConstant[] Tags { get; private set; }
        
        
        private static Dictionary<string, List<GameObject>> taggedGOs = new Dictionary<string, List<GameObject>>();
        private static Dictionary<GameObject, AtomicTags> instances = new Dictionary<GameObject, AtomicTags>();
        
        public void AddTag(StringConstant tag) {
            tags.Add(tag);
            tags.Sort((x, y) => String.Compare(x.Value, y.Value, StringComparison.Ordinal));
            Tags = tags.ToArray();
        }

        public void RemoveTag(string tag) {
            for (var i = tags.Count - 1; i >= 0; i--) {
                if (tags[i].Value == tag) {
                   tags.RemoveAt(i);
                }
            }
            tags.Sort((x, y) => String.Compare(x.Value, y.Value, StringComparison.Ordinal));
            Tags = tags.ToArray();
        } 
        
        private void OnValidate() {
            tags.Sort((x, y) => String.Compare(x.Value, y.Value, StringComparison.Ordinal));
        }

        private void OnEnable() {
            tags.Sort((x, y) => String.Compare(x.Value, y.Value, StringComparison.Ordinal));
            Tags = tags.ToArray();
            
            if(! instances.ContainsKey(this.gameObject)) instances.Add(this.gameObject, this);
            foreach (var stringConstant in tags) {
                var tag = stringConstant.Value;
                if(! taggedGOs.ContainsKey(tag)) taggedGOs.Add(tag, new List<GameObject>());
                taggedGOs[tag].Add(this.gameObject);
            };
        }

        private void OnDisable(){
            if(instances.ContainsKey(this.gameObject)) instances.Remove(this.gameObject);
            foreach (var stringConstant in tags) {
                var tag = stringConstant.Value;
                if(taggedGOs.ContainsKey(tag)) taggedGOs[tag].Remove(this.gameObject);
            };
        }

        /// <summary>
        /// Faster alternative to go.GetComponent&lt;AtomicTags&gt;() since they are already cached in a dictionary
        /// </summary>
        /// <returns>
        /// - null if the GameObject does not have AtomicTags or they (or the GO) are disabled
        /// - the AtomicTag component
        /// </returns>
        public static AtomicTags GetForGameObject(GameObject go) {
            if (!instances.ContainsKey(go)) return null;
            return instances[go];
        }
        
        /// <summary>
        /// Retrieves all AtomicTags for a given GameObject
        /// </summary>
        /// <returns>
        /// - null if the GameObject does not have AtomicTags or they (or the GO) are disabled
        /// - an array of strings containing the tags
        /// </returns>
        public static string[] GetAtomicTags(GameObject go) {
            if (!instances.ContainsKey(go)) return null;
            var atomicTags = instances[go];
            string[] result = new string[atomicTags.tags.Count];
            for (var i = 0; i < result.Length; i++) {
                result[i] = atomicTags.tags[i].Value;
            }
            return result;
        }
        
    }
}
