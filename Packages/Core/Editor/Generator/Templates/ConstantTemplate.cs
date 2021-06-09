using System;
using UnityEditor;

namespace UnityAtoms.Editor
{
    [InitializeOnLoad]
    public static class ConstantTemplate
    {
        static ConstantTemplate()
        {
            AtomGenerator.resolvers.Add("Constant", ResolveConstant);
        }

        public static string ResolveConstant(Type type, out string className, string withNamespace = default)
        {
            type = typeof(AtomBaseVariable<>).MakeGenericType(type);
            return Template.ResolveAtom(type, out className, withNamespace);
        }
    }
}
