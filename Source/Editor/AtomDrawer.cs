#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;
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
}
#endif
