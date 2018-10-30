using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms
{
    public class ColorListener : GameEventListener<Color, ColorAction, ColorEvent, UnityColorEvent> { }
}
