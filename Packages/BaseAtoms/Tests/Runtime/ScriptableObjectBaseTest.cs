using System.Reflection;
using NUnit.Framework;
using UnityAtoms.BaseAtoms;
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
            Assert.AreNotEqual("some constant string".GetHashCode(), stringConstant.GetHashCode());
            Assert.AreNotEqual(stringConstant2, stringConstant);
            Assert.AreEqual(stringConstant2, stringConstant2);
            Assert.IsFalse(stringConstant2 == stringConstant);
            Assert.IsFalse(stringConstant3 == stringConstant);
        }
    }
}
