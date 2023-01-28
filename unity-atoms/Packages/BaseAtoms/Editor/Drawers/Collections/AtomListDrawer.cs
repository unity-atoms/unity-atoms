using UnityEditor;
using UnityEngine;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// A custom property drawer for AtomBaseVariableList. 
    /// </summary>
    [CustomPropertyDrawer(typeof(AtomBaseVariableList))]
    public class AtomListDrawer : AtomListAttributeDrawer { }
}