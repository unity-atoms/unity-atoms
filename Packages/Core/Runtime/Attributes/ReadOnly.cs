using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Use to make a field read only in the Unity inspector. Solution taken from here: https://answers.unity.com/questions/489942/how-to-make-a-readonly-property-in-inspector.html
    /// </summary>
    public class ReadOnlyAttribute : PropertyAttribute { }
}