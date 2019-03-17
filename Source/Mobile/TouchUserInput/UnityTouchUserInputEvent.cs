using System;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms.Mobile
{
    [Serializable]
    public class UnityTouchUserInputEvent : UnityEvent<TouchUserInput> { }

    [Serializable]
    public class UnityTouchUserInputTouchUserInputEvent : UnityEvent<TouchUserInput, TouchUserInput> { }
}