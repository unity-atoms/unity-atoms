using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Custom editor for ClampFloat.
    /// </summary>
    [CustomEditor(typeof(ClampFloat))]
    public class ClampFloatEditor : ClampBaseEditor { }
}
