using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;
using UnityAtoms;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class AtomicTagTests
    {
        
        [UnityTest]
        public IEnumerator AtomicTagTests_HasAnyTagTest(){
            var go = new GameObject();
            var atomicTags = go.AddComponent<AtomicTags>();

            string[] random_tags_raw = new[] {"a", "c", "e", "g", "i", "k", "m"};
            var random_tags_shuffled = random_tags_raw.OrderBy((s => Random.value)).ToList();
                
            
            var fieldinfo = typeof(StringConstant).GetField("value", BindingFlags.NonPublic | BindingFlags.Instance);
            
            
            for (int i = 0; i < random_tags_shuffled.Count; ++i) {
                var stringConstant = ScriptableObject.CreateInstance<StringConstant>();
                fieldinfo.SetValue(stringConstant, random_tags_shuffled[i]);
                atomicTags.AddTag(stringConstant);
            }

            yield return null;
            yield return new WaitForFixedUpdate();

            Assert.NotNull(atomicTags);
            Assert.NotNull(atomicTags.Tags);
            
            // check if the tags are actually sorted:
            // Debug.Log(atomicTags.Tags.Select(t => t.Value).Aggregate((a, b) => a + ", " + b));
            {
                int i = 0;
                foreach (var atomicTagsTag in atomicTags.Tags) {
                    Assert.AreEqual(random_tags_raw[i], atomicTagsTag.Value);
                    ++i;
                }
            }

            Assert.IsFalse(go.HasAnyTag(new List<string>() {"b", "d", "f", "h", "j", "l"}));
            Assert.IsTrue(go.HasAnyTag(new List<string>() {"b", "d", "f", "h", "j", "m"}));

        }

    }
}
