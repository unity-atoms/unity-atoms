#if UNITY_2019_1_OR_NEWER
using System.Collections;
using NUnit.Framework;
using Unity.Profiling;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.TestTools.Constraints;
using Is = UnityEngine.TestTools.Constraints.Is;

namespace Tests
{
    public class AtomPerformanceTests
    {

        [UnityTest]
        public IEnumerator TestingAndProfiling_IntVariable()
        {
            var go = new GameObject();
            
            var testIntVariable = ScriptableObject.CreateInstance<IntVariable>();
            
            yield return null;
            yield return new WaitForFixedUpdate();

            // with the help of those ProfilerMarkers you can check GC Alloc in the Profiler Window Pretty easy
            // an alternative would be: https://docs.unity3d.com/2018.3/Documentation/ScriptReference/TestTools.Constraints.AllocatingGCMemoryConstraint.html
            // Assert.That(() => { }, Is.Not.AllocatingGCMemory()); but it does not work correctly half of the time

            using (new ProfilerMarker("AtomPerformanceTests.IntVariable.FirstIncrement").Auto())
            {
                testIntVariable.Value++;
            }
            
            using (new ProfilerMarker("AtomPerformanceTests.IntVariable.Increments").Auto())
            {
                for (int i = 0; i < 10000; ++i)
                {
                    testIntVariable.Value++;
                }
            }
            
            Assert.That(() =>
            {
                testIntVariable.Value++;
            }, Is.Not.AllocatingGCMemory());
           

            yield return null;
        }
        
        [UnityTest]
        public IEnumerator TestingAndProfiling_Vector3Variable()
        {
            var go = new GameObject();
            
            var testVector3Variable = ScriptableObject.CreateInstance<Vector3Variable>();
            
            yield return null;
            yield return new WaitForFixedUpdate();

            // with the help of those ProfilerMarkers you can check GC Alloc in the Profiler Window Pretty easy
            // an alternative would be: https://docs.unity3d.com/2018.3/Documentation/ScriptReference/TestTools.Constraints.AllocatingGCMemoryConstraint.html
            // Assert.That(() => { }, Is.Not.AllocatingGCMemory()); but it does not work correctly half of the time

            using (new ProfilerMarker("AtomPerformanceTests.Vector3Variable.FirstIncrement").Auto())
            {
                testVector3Variable.Value += new Vector3(1, 0, 1);
            }
            
            using (new ProfilerMarker("AtomPerformanceTests.Vector3Variable.Increments").Auto())
            {
                for (int i = 0; i < 10000; ++i)
                {
                    testVector3Variable.Value += new Vector3(1, 0, 1);
                }
            }
            
            Assert.That(() =>
            {
                testVector3Variable.Value += new Vector3(1, 0, 1);
            }, Is.Not.AllocatingGCMemory());
           

            yield return null;
        }


    }
}
#endif