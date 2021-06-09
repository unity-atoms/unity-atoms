using System;
using UnityEditor;

namespace UnityAtoms.Editor
{
    [InitializeOnLoad]
    public static class EventTemplate
    {
        static EventTemplate()
        {
            AtomGenerator.resolvers.Add("Event", ResolveEvent);
            AtomGenerator.resolvers.Add("Pair Event", ResolvePairEvent);
        }

        public static string ResolveEvent(Type type, out string className, string withNamespace = default)
        {
            type = typeof(AtomEvent<>).MakeGenericType(type);
            return Template.ResolveAtom(type, out className, withNamespace);
        }

        public static string ResolvePairEvent(Type type, out string className, string withNamespace = default)
        {
            type = typeof(Pair<>).MakeGenericType(type);
            return ResolveEvent(type, out className, withNamespace);
        }
    }
}
