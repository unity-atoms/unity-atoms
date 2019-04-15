using UnityEditor;
using UnityEngine;

namespace UnityAtoms
{
    public abstract class GameEventEditor<T, E> : UnityEditor.Editor
        where E : GameEvent<T>
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
    public sealed class BoolEventEditor : GameEventEditor<bool, BoolEvent> { }

    [CustomEditor(typeof(Collider2DEvent))]
    public sealed class Collider2DEventEditor : GameEventEditor<Collider2D, Collider2DEvent> { }

    [CustomEditor(typeof(ColorEvent))]
    public sealed class ColorEventEditor : GameEventEditor<Color, ColorEvent> { }

    [CustomEditor(typeof(FloatEvent))]
    public sealed class FloatEventEditor : GameEventEditor<float, FloatEvent> { }

    [CustomEditor(typeof(GameObjectEvent))]
    public sealed class GameObjectEventEditor : GameEventEditor<GameObject, GameObjectEvent> { }

    [CustomEditor(typeof(IntEvent))]
    public sealed class IntGameEventEditor : GameEventEditor<int, IntEvent> { }

    [CustomEditor(typeof(Vector2Event))]
    public sealed class Vector2EventEditor : GameEventEditor<Vector2, Vector2Event> { }

    [CustomEditor(typeof(Vector3Event))]
    public sealed class Vector3EventEditor : GameEventEditor<Vector3, Vector3Event> { }

    [CustomEditor(typeof(VoidEvent))]
    public sealed class VoidEventEditor : GameEventEditor<Void, VoidEvent> { }
}
