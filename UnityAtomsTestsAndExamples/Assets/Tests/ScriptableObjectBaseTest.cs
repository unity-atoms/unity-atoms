using System.Reflection;
using NUnit.Framework;
using UnityAtoms;
using UnityEngine;

namespace Tests
{
    public class ScriptableObjectBaseTest
    {

        [Test]
        public void ScriptableObjectBaseTest_EqualityMembers()
        {

            var fieldinfo = typeof(StringConstant).GetField("_value", BindingFlags.NonPublic | BindingFlags.Instance);

            var stringConstant = ScriptableObject.CreateInstance<StringConstant>();
            fieldinfo.SetValue(stringConstant, "some constant string");

            var stringConstant2 = ScriptableObject.CreateInstance<StringConstant>();
            fieldinfo.SetValue(stringConstant2, "some constant string");

            var stringConstant3 = ScriptableObject.CreateInstance<StringConstant>();
            fieldinfo.SetValue(stringConstant3, "some other string");

            Assert.AreEqual("some constant string".GetHashCode(), stringConstant.Value.GetHashCode());
            Assert.AreEqual("some constant string".GetHashCode(), stringConstant.GetHashCode());
            Assert.AreEqual(stringConstant2, stringConstant);
            Assert.IsTrue(stringConstant2 == stringConstant);
            Assert.IsFalse(stringConstant3 == stringConstant);
        }
    }
}
