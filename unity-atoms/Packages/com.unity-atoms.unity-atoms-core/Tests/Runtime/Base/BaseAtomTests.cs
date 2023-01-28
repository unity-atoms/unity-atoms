using NUnit.Framework;
using UnityAtoms;
using System.Linq;

public class BaseAtomTests
{
    [Test]
    public void Has_AtomsSearchable_attribute()
    {
        var _attribute = typeof(BaseAtom).GetCustomAttributes(typeof(AtomsSearchable), true).FirstOrDefault() as AtomsSearchable;

        Assert.NotNull(_attribute);
    }
}