#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// SerializableDictionary property drawer for type &lt;StringReference, AtomBaseVariable&gt;. Inherits from `SerializableDictionaryDrawer&lt;StringReference, AtomBaseVariable, StringReferenceAtomBaseVariableDictionary&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(StringReferenceAtomBaseVariableDictionary))]
    public class StringReferenceAtomBaseVariableDictionaryDrawer : SerializableDictionaryDrawer<StringReference, AtomBaseVariable, StringReferenceAtomBaseVariableDictionary> { }
}
#endif
