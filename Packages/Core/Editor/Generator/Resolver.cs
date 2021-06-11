using System;

namespace UnityAtoms.Editor
{
    public delegate string Resolver(Type type, out string className, string withNamespace = default);
}
