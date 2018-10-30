
using UnityEngine;

namespace UnityAtoms
{
    //    public class CreateEventOnAwake<T, E1, E2, L1, L2, GA1, GA2, UER1, UER2> : MonoBehaviour
    //     where E1 : GameEvent<T> where E2 : GameEvent<T, GameObject>
    //     where L1 : GameEventListener<T, GA1, E1, UER1> where L2 : GameEventListener<T, GameObject, GA2, E2, UER2>
    //     where GA1 : GameAction<T> where GA2 : GameAction<T, GameObject>
    //     where UER1 : UnityEvent<T> where UER2 : UnityEvent<T, GameObject>
    public class CreateCollider2DEventOnAwake : CreateEventOnAwake<
        Collider2D, Collider2DEvent, Collider2DGameObjectEvent,
        Collider2DListener, Collider2DGameObjectListener,
        Collider2DAction, Collider2DGameObjectAction,
        UnityCollider2DEvent, UnityCollider2DGameObjectEvent,
        Collider2DHook
        >
    { }
}