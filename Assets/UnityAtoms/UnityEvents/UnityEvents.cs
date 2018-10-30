using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public class UnityBoolEvent : UnityEvent<bool> { }
    [Serializable]
    public class UnityCollider2DEvent : UnityEvent<Collider2D> { }
    [Serializable]
    public class UnityColorEvent : UnityEvent<Color> { }
    [Serializable]
    public class UnityFloatEvent : UnityEvent<float> { }
    [Serializable]
    public class UnityGameObjectEvent : UnityEvent<GameObject> { }
    [Serializable]
    public class UnityIntEvent : UnityEvent<int> { }
    [Serializable]
    public class UnityVector2Event : UnityEvent<Vector2> { }
    [Serializable]
    public class UnityVector3Event : UnityEvent<Vector3> { }
    [Serializable]
    public class UnityVoidEvent : UnityEvent<Void> { }


    [Serializable]
    public class UnityCollider2DGameObjectEvent : UnityEvent<Collider2D, GameObject> { }
    [Serializable]
    public class UnityVoidGameObjectEvent : UnityEvent<Void, GameObject> { }
}