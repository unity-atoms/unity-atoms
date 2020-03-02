using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Custom editor for ClampFloat.
    /// </summary>
    [CustomEditor(typeof(ClampFloat))]
    public class ClampFloatEditor : ClampBaseEditor { }
}
