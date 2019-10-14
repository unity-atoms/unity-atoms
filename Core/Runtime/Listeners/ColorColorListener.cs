using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Color - Color")]
    public sealed class ColorColorListener : AtomListener<
        Color,
        Color,
        ColorColorAction,
        ColorColorEvent,
        ColorColorUnityEvent>
    { }
}
