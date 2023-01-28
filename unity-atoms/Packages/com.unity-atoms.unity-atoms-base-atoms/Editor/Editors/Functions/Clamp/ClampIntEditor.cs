using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Custom editor for ClampInt.
    /// </summary>
    [CustomEditor(typeof(ClampInt))]
    public class ClampIntEditor : UnityEditor.Editor { }
}
