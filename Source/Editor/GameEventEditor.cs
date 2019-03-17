using UnityEditor;
using UnityEngine;

namespace UnityAtoms
{
    public class GameEventEditor<T, E> : Editor where E : GameEvent<T>
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            E e = target as E;
            if (GUILayout.Button("Raise"))
            {
                e.Raise(default(T));
            }
        }
    }

    [CustomEditor(typeof(BoolEvent))]
    public class BoolEventEditor : GameEventEditor<bool, BoolEvent> { }

    [CustomEditor(typeof(Collider2DEvent))]
    public class Collider2DEventEditor : GameEventEditor<Collider2D, Collider2DEvent> { }

    [CustomEditor(typeof(ColorEvent))]
    public class ColorEventEditor : GameEventEditor<Color, ColorEvent> { }

    [CustomEditor(typeof(FloatEvent))]
    public class FloatEventEditor : GameEventEditor<float, FloatEvent> { }

    [CustomEditor(typeof(GameObjectEvent))]
    public class GameObjectEventEditor : GameEventEditor<GameObject, GameObjectEvent> { }

    [CustomEditor(typeof(IntEvent))]
    public class IntGameEventEditor : GameEventEditor<int, IntEvent> { }

    [CustomEditor(typeof(Vector2Event))]
    public class Vector2EventEditor : GameEventEditor<Vector2, Vector2Event> { }

    [CustomEditor(typeof(Vector3Event))]
    public class Vector3EventEditor : GameEventEditor<Vector3, Vector3Event> { }

    [CustomEditor(typeof(VoidEvent))]
    public class VoidEventEditor : GameEventEditor<Void, VoidEvent> { }
}