using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityAtoms;

namespace UnityAtoms.Mobile
{
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/TouchUserInput", fileName = "TouchUserInputVariable")]
    public sealed class TouchUserInputVariable : EquatableAtomVariable<
        TouchUserInput,
        TouchUserInputEvent,
        TouchUserInputTouchUserInputEvent>
    { }

}
