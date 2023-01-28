using NUnit.Framework;
using UnityAtoms;
using NSubstitute;

public class AtomListAttributeTests
{
    [Test]
    public void Assigns_correct_properties()
    {
        string _label = "label";
        string _childPropName = "childPropName";
        bool _includeChildrenForItems = false;
        var _atomListAttribute = Substitute.For<AtomListAttribute>(_label, _childPropName, _includeChildrenForItems);

        Assert.AreEqual(_atomListAttribute.Label, _label);
        Assert.AreEqual(_atomListAttribute.ChildPropName, _childPropName);
        Assert.AreEqual(_atomListAttribute.IncludeChildrenForItems, _includeChildrenForItems);
    }
}