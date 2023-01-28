using NUnit.Framework;
using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace BaseAtoms
{
    public class IntVariableValueTests
    {
        private IntVariable variable;

        [SetUp]
        public void Setup()
        {
            variable = ScriptableObject.CreateInstance(typeof(IntVariable)) as IntVariable;
        }

        [TearDown]
        public void Teardown()
        {
            ScriptableObject.DestroyImmediate(variable);
        }

        [Test]
        public void When_ValuesAreAssigned_Expect_ValuesCanBeRead()
        {
            variable.Value = 5;
            Assert.AreEqual(5, variable.Value);

            variable.Value = 10;
            Assert.AreEqual(10, variable.Value);
        }

        [Test]
        public void When_NewValuesAreAssigned_Expect_OldValueIsPreviousValue()
        {
            variable.Value = 5;
            Assert.AreEqual(5, variable.Value);

            variable.Value = 10;
            Assert.AreEqual(5, variable.OldValue);

            variable.Value = 5;
            Assert.AreEqual(10, variable.OldValue);
        }

        [Test]
        public void When_ResetIsCalled_Expect_ValueIsReset()
        {
            variable.Value = 5;
            Assert.AreEqual(5, variable.Value);

            variable.Reset();
            Assert.AreEqual(0, variable.Value);
        }
    }
}
