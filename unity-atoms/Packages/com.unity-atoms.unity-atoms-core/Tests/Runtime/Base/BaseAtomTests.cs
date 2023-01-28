using NUnit.Framework;
using UnityAtoms;
using FluentAssertions;

public class BaseAtomTests
{
    [Test]
    public void Has_AtomsSearchable_attribute()
    {
        typeof(BaseAtom).Should().BeDecoratedWith<AtomsSearchable>();
    }
}