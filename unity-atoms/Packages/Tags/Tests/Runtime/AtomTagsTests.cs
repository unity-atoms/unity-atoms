using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;
using Unity.Profiling;
using UnityEngine.TestTools;
using UnityAtoms.BaseAtoms;
using UnityAtoms.Tags;
using UnityEngine;
using UnityEngine.TestTools.Constraints;
using Is = UnityEngine.TestTools.Constraints.Is;
using Random = UnityEngine.Random;

namespace UnityAtoms.Tags.Tests
{
    public class AtomTagsTests
    {

        [UnityTest]
        public IEnumerator TestingAndProfiling()
        {
            var go = new GameObject();
            var atomicTags = go.AddComponent<AtomTags>();

            List<string> random_tags_raw = new List<string>() { "a", "c", "e", "g", "i", "k", "m" };
            random_tags_raw.OrderBy((s => Random.value)).ToList();

            var fieldinfo = typeof(StringConstant).GetField("_value", BindingFlags.NonPublic | BindingFlags.Instance);
            for (int i = 0; i < random_tags_raw.Count; ++i)
            {
                var stringConstant = ScriptableObject.CreateInstance<StringConstant>();
                fieldinfo.SetValue(stringConstant, random_tags_raw[i]);
                atomicTags.AddTag(stringConstant);
            }



            var newConstant = ScriptableObject.CreateInstance<StringConstant>();
            fieldinfo.SetValue(newConstant, "b");

            yield return null;
            yield return new WaitForFixedUpdate();

            // with the help of those ProfilerMarkers you can check GC Alloc in the Profiler Window Pretty easy
            // an alternative would be: https://docs.unity3d.com/2018.3/Documentation/ScriptReference/TestTools.Constraints.AllocatingGCMemoryConstraint.html
            // Assert.That(() => { }, Is.Not.AllocatingGCMemory()); but it does not work correctly half of the time

            Assert.That(() => { var t1 = atomicTags.Tags; }, Is.Not.AllocatingGCMemory());
            Assert.That(() => { var t1 = atomicTags.Tags[1]; }, Is.Not.AllocatingGCMemory());
            Assert.That(() => { var t1 = atomicTags.Tags[2].Value; }, Is.Not.AllocatingGCMemory());
            Assert.That(() => { atomicTags.HasTag(null); }, Is.Not.AllocatingGCMemory());

            Assert.AreSame(go, AtomTags.FindByTag("e"));
            using (new ProfilerMarker("MySystem.FindByTag").Auto())
            {
                AtomTags.FindByTag("e");
            }
            // THIS:
            // Assert.That(() => { var t1 = AtomicTags.FindByTag("e"); }, Is.AllocatingGCMemory());
            // says it allocates, the profiler says it does not

            using (new ProfilerMarker("MySystem.MultpleGet").Auto())
            {
                var t1 = atomicTags.Tags;
                var t10 = t1[0];
                var t11 = atomicTags.Tags[0];
                var t2 = atomicTags.Tags;
            }

            using (new ProfilerMarker("MySystem.GetGlobal").Auto())
            {
                AtomTags.GetTagsForGameObject(go);
            }

            Assert.AreEqual(random_tags_raw.Count, atomicTags.Tags.Count);

            for (var i = 0; i < atomicTags.Tags.Count - 1; i++)
            {
                Assert.IsTrue(String.CompareOrdinal(atomicTags.Tags[i].Value, atomicTags.Tags[i + 1].Value) < 0);
            }
            using (new ProfilerMarker("MySystem.AddCompletelyNewTag").Auto())
            {
                atomicTags.AddTag(newConstant);
            }

            Assert.AreEqual(random_tags_raw.Count + 1, atomicTags.Tags.Count);

            for (var i = 0; i < atomicTags.Tags.Count - 1; i++)
            {
                Assert.IsTrue(String.CompareOrdinal(atomicTags.Tags[i].Value, atomicTags.Tags[i + 1].Value) < 0);
            }

            using (new ProfilerMarker("MySystem.RemoveTag").Auto())
            {
                atomicTags.RemoveTag(newConstant.Value);
            }

            Assert.AreEqual(random_tags_raw.Count, atomicTags.Tags.Count);
            Assert.IsFalse(atomicTags.HasTag(newConstant.Value));

            using (new ProfilerMarker("MySystem.AddTagAgain").Auto())
            {
                atomicTags.AddTag(newConstant);
            }

            Assert.IsTrue(atomicTags.HasTag("a"));
            using (new ProfilerMarker("MySystem.HasTagTrue1").Auto())
            {
                atomicTags.HasTag("a");
            }

            Assert.IsTrue(go.HasTag("a"));
            using (new ProfilerMarker("MySystem.HasTagTrue1Global").Auto())
            {
                go.HasTag("a");
            }

            Assert.IsTrue(go.HasTag("m"));
            using (new ProfilerMarker("MySystem.HasTagTrue2").Auto())
            {
                go.HasTag("m");
            }

            Assert.IsFalse(go.HasTag("z"));
            using (new ProfilerMarker("MySystem.HasTagFalse").Auto())
            {
                go.HasTag("z");
            }

            var falseList = new List<string>() { "d", "f", "h", "j", "l" };
            var truelist = new List<string>() { "d", "f", "h", "j", "m" };

            Assert.IsFalse(go.HasAnyTag(falseList));
            using (new ProfilerMarker("MySystem.HasAnyTag_allFalse").Auto())
            {
                go.HasAnyTag(falseList);
            }

            Assert.IsTrue(go.HasAnyTag(truelist));
            using (new ProfilerMarker("MySystem.HasAnyTag_lastTrue").Auto())
            {
                go.HasAnyTag(truelist);
            }



            yield return null;
        }



    }
}
