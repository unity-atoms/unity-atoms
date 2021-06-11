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
            AtomGenerator.resolvers.Add("Event Pair", ResolveEventPair);
        }

        private static readonly string voidMethod =
$@"public override void Raise()
{{
    Raise(new Void());
}}";

        public static string ResolveEvent(Type type, out string className, string withNamespace = default)
        {
            var eventType = typeof(AtomEvent<>).MakeGenericType(type);
            if(type != typeof(Void))
            {
                return Template.ResolveAtomAsset(eventType, out className, withNamespace);
            }

            var templateData = TemplateData.Generate(eventType, out className, withNamespace);
            var content = Template.Resolve(templateData, className, methodsString: voidMethod);
            return content;
        }

        public static string ResolveEventPair(Type type, out string className, string withNamespace = default)
        {
            var pairType = typeof(Pair<>).MakeGenericType(type);
            if(type != typeof(Void))
            {
                return ResolveEvent(pairType, out className, withNamespace);
            }

            var eventType = typeof(AtomEvent<>).MakeGenericType(pairType);

            var templateData = TemplateData.Generate(eventType, out className, withNamespace);
            var content = Template.Resolve(templateData, className, methodsString: voidMethod);
            return content;
        }
    }
}
