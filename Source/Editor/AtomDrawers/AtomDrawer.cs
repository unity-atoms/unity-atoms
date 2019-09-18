#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine;

namespace UnityAtoms
{
    public abstract class AtomDrawer<T> : PropertyDrawer where T : ScriptableObject
    {
        private bool _userClickedToCreateAtom = false;
        private string _nameOfNewAtom = "";
        private string _warningText = "";

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var isCreatingSO = _userClickedToCreateAtom && property.objectReferenceValue == null;
            if (!isCreatingSO || _warningText.Length <= 0) return base.GetPropertyHeight(property, label);
            return base.GetPropertyHeight(property, label) * 2 + 4f;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var isCreatingSO = _userClickedToCreateAtom && property.objectReferenceValue == null;
            var restWidth = _userClickedToCreateAtom ? 50 : 58;
            var gutter = _userClickedToCreateAtom ? 2f : 6f;
            Rect restRect = new Rect();
            Rect warningRect = new Rect();

            EditorGUI.BeginProperty(position, label, property);

            if (_warningText.Length > 0)
            {
                position = IMGUIUtils.SnipRectV(position, EditorGUIUtility.singleLineHeight, out warningRect, 2f);
            }

            if (property.objectReferenceValue == null)
            {
                position = IMGUIUtils.SnipRectH(position, position.width - restWidth, out restRect, gutter);
            }

            var defaultGUIColor = GUI.color;
            GUI.color = isCreatingSO ? Color.yellow : defaultGUIColor;
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), isCreatingSO ? new GUIContent("Name of New Atom") : label);
            GUI.color = defaultGUIColor;

            if (isCreatingSO)
            {
                _nameOfNewAtom = EditorGUI.TextField(position, _nameOfNewAtom);
            }
            else
            {
                property.objectReferenceValue = EditorGUI.ObjectField(position, property.objectReferenceValue, typeof(T), false);
            }

            if (property.objectReferenceValue == null)
            {
                if (isCreatingSO)
                {
                    var buttonWidth = 24;
                    Rect secondButtonRect;
                    Rect firstButtonRect = IMGUIUtils.SnipRectH(restRect, restRect.width - buttonWidth, out secondButtonRect, gutter);
                    if (GUI.Button(firstButtonRect, "✓"))
                    {
                        if (_nameOfNewAtom.Length > 0)
                        {
                            try
                            {
                                // Create asset
                                T so = ScriptableObject.CreateInstance<T>();
                                AssetDatabase.CreateAsset(so, "Assets/" + _nameOfNewAtom + ".asset");
                                AssetDatabase.SaveAssets();
                                // Assign the newly created SO
                                property.objectReferenceValue = so;
                            }
                            catch
                            {
                                Debug.LogError("Not able to create Atom");
                            }

                            _userClickedToCreateAtom = false;
                            _warningText = "";
                        }
                        else
                        {
                            _warningText = "Name of new Atom must be specified!";
                        }
                    }
                    if (GUI.Button(secondButtonRect, "✗"))
                    {
                        _userClickedToCreateAtom = false;
                        _warningText = "";
                    }

                    if (_warningText.Length > 0)
                    {
                        EditorGUI.HelpBox(warningRect, _warningText, MessageType.Warning);
                    }
                }
                else
                {
                    if (GUI.Button(restRect, "Create"))
                    {
                        _nameOfNewAtom = "";
                        _userClickedToCreateAtom = true;
                    }
                }
            }

            EditorGUI.EndProperty();
        }
    }

    // Events
    [CustomPropertyDrawer(typeof(BoolEvent))]
    public class BoolEventDrawer : AtomDrawer<BoolEvent> { }

    [CustomPropertyDrawer(typeof(ColliderEvent))]
    public class ColliderEventDrawer : AtomDrawer<ColliderEvent> { }

    [CustomPropertyDrawer(typeof(Collider2DEvent))]
    public class Collider2DEventDrawer : AtomDrawer<Collider2DEvent> { }

    [CustomPropertyDrawer(typeof(ColorEvent))]
    public class ColorEventDrawer : AtomDrawer<ColorEvent> { }

    [CustomPropertyDrawer(typeof(FloatEvent))]
    public class FloatEventDrawer : AtomDrawer<FloatEvent> { }

    [CustomPropertyDrawer(typeof(GameObjectEvent))]
    public class GameObjectEventDrawer : AtomDrawer<GameObjectEvent> { }

    [CustomPropertyDrawer(typeof(IntEvent))]
    public class IntEventDrawer : AtomDrawer<IntEvent> { }

    [CustomPropertyDrawer(typeof(StringEvent))]
    public class StringEventDrawer : AtomDrawer<StringEvent> { }

    [CustomPropertyDrawer(typeof(Vector2Event))]
    public class Vector2EventDrawer : AtomDrawer<Vector2Event> { }

    [CustomPropertyDrawer(typeof(Vector3Event))]
    public class Vector3EventDrawer : AtomDrawer<Vector3Event> { }

    [CustomPropertyDrawer(typeof(VoidEvent))]
    public class VoidEventDrawer : AtomDrawer<VoidEvent> { }

    [CustomPropertyDrawer(typeof(Collision2DEvent))]
    public class Collision2DEventDrawer : AtomDrawer<Collision2DEvent> { }

    [CustomPropertyDrawer(typeof(CollisionEvent))]
    public class CollisionEventDrawer : AtomDrawer<CollisionEvent> { }


    // Event x 2
    [CustomPropertyDrawer(typeof(BoolBoolEvent))]
    public class BoolBoolEventDrawer : AtomDrawer<BoolBoolEvent> { }

    [CustomPropertyDrawer(typeof(ColorColorEvent))]
    public class ColorColorEventDrawer : AtomDrawer<ColorColorEvent> { }

    [CustomPropertyDrawer(typeof(FloatFloatEvent))]
    public class FloatFloatEventDrawer : AtomDrawer<FloatFloatEvent> { }

    [CustomPropertyDrawer(typeof(GameObjectGameObjectEvent))]
    public class GameObjectGameObjectEventDrawer : AtomDrawer<GameObjectGameObjectEvent> { }

    [CustomPropertyDrawer(typeof(IntIntEvent))]
    public class IntIntEventDrawer : AtomDrawer<IntIntEvent> { }

    [CustomPropertyDrawer(typeof(StringStringEvent))]
    public class StringStringEventDrawer : AtomDrawer<StringStringEvent> { }

    [CustomPropertyDrawer(typeof(Vector2Vector2Event))]
    public class Vector2Vector2EventDrawer : AtomDrawer<Vector2Vector2Event> { }

    [CustomPropertyDrawer(typeof(Vector3Vector3Event))]
    public class Vector3Vector3EventDrawer : AtomDrawer<Vector3Vector3Event> { }


    // Constants
    [CustomPropertyDrawer(typeof(BoolConstant))]
    public class BoolConstantDrawer : AtomDrawer<BoolConstant> { }

    [CustomPropertyDrawer(typeof(ColorConstant))]
    public class ColorConstantDrawer : AtomDrawer<ColorConstant> { }

    [CustomPropertyDrawer(typeof(FloatConstant))]
    public class FloatConstantDrawer : AtomDrawer<FloatConstant> { }

    [CustomPropertyDrawer(typeof(IntConstant))]
    public class IntConstantDrawer : AtomDrawer<IntConstant> { }

    [CustomPropertyDrawer(typeof(StringConstant))]
    public class StringConstantDrawer : AtomDrawer<StringConstant> { }

    [CustomPropertyDrawer(typeof(Vector2Constant))]
    public class Vector2ConstantDrawer : AtomDrawer<Vector2Constant> { }

    [CustomPropertyDrawer(typeof(Vector3Constant))]
    public class Vector3ConstantDrawer : AtomDrawer<Vector3Constant> { }


    // Lists
    [CustomPropertyDrawer(typeof(BoolList))]
    public class BoolListDrawer : AtomDrawer<BoolList> { }

    [CustomPropertyDrawer(typeof(Collider2DList))]
    public class Collider2DListDrawer : AtomDrawer<Collider2DList> { }

    [CustomPropertyDrawer(typeof(ColorList))]
    public class ColorListDrawer : AtomDrawer<ColorList> { }

    [CustomPropertyDrawer(typeof(FloatList))]
    public class FloatListDrawer : AtomDrawer<FloatList> { }

    [CustomPropertyDrawer(typeof(GameObjectList))]
    public class GameObjectListDrawer : AtomDrawer<GameObjectList> { }

    [CustomPropertyDrawer(typeof(IntList))]
    public class IntListDrawer : AtomDrawer<IntList> { }

    [CustomPropertyDrawer(typeof(StringList))]
    public class StringListDrawer : AtomDrawer<StringList> { }

    [CustomPropertyDrawer(typeof(Vector2List))]
    public class Vector2ListDrawer : AtomDrawer<Vector2List> { }

    [CustomPropertyDrawer(typeof(Vector3List))]
    public class Vector3ListDrawer : AtomDrawer<Vector3List> { }

    [CustomPropertyDrawer(typeof(Collision2DList))]
    public class Collision2DListDrawer : AtomDrawer<Collision2DList> { }

    [CustomPropertyDrawer(typeof(CollisionList))]
    public class CollisionListDrawer : AtomDrawer<CollisionList> { }


    // Variables
    [CustomPropertyDrawer(typeof(BoolVariable))]
    public class BoolVariableDrawer : AtomDrawer<BoolVariable> { }

    [CustomPropertyDrawer(typeof(ColorVariable))]
    public class ColorVariableDrawer : AtomDrawer<ColorVariable> { }

    [CustomPropertyDrawer(typeof(FloatVariable))]
    public class FloatVariableDrawer : AtomDrawer<FloatVariable> { }

    [CustomPropertyDrawer(typeof(GameObjectVariable))]
    public class GameObjectVariableDrawer : AtomDrawer<GameObjectVariable> { }

    [CustomPropertyDrawer(typeof(IntVariable))]
    public class IntVariableDrawer : AtomDrawer<IntVariable> { }

    [CustomPropertyDrawer(typeof(StringVariable))]
    public class StringVariableDrawer : AtomDrawer<StringVariable> { }

    [CustomPropertyDrawer(typeof(Vector2Variable))]
    public class Vector2VariableDrawer : AtomDrawer<Vector2Variable> { }

    [CustomPropertyDrawer(typeof(Vector3Variable))]
    public class Vector3VariableDrawer : AtomDrawer<Vector3Variable> { }
}
#endif
