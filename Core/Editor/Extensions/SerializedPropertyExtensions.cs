using System;
using System.Reflection;
using System.Linq;
using System.Collections;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    public static class SerializedPropertyExtensions
    {
        /// <summary>
        /// Generic method that tries to retrieve a value from a SerializedProperty of a specfic type.
        /// </summary>
        /// <param name="property">The SerializedProperty.</param>
        /// <param name="managedObjectOut">Managed object.</param>
        /// <typeparam name="T"></typeparam>
        /// <returns>The value of type T.</returns>
        public static T GetGenericPropertyValue<T>(this SerializedProperty property, T managedObjectOut)
        {
            object box = managedObjectOut;
            var type = managedObjectOut.GetType();
            foreach (var field in type.GetFields(BindingFlags.Instance | BindingFlags.Public))
            {
                try
                {
                    field.SetValue(box, property.FindPropertyRelative(field.Name).GetPropertyValue());
                }
                catch (InvalidOperationException)
                {
                }
            }
            return (T)box;
        }

        /// <summary>
        /// Get property value from SerializedProperty.
        /// </summary>
        /// <param name="property">The SerializedProperty.</param>
        /// <returns>The value as an object.</returns>
        public static object GetPropertyValue(this SerializedProperty property)
        {
            if (property == null) throw new ArgumentNullException(nameof(property));
            switch (property.propertyType)
            {
                case SerializedPropertyType.ObjectReference: return property.objectReferenceValue;
                case SerializedPropertyType.ArraySize: return property.arraySize;
                case SerializedPropertyType.Integer: return property.intValue;
                case SerializedPropertyType.Boolean: return property.boolValue;
                case SerializedPropertyType.Float: return property.floatValue;
                case SerializedPropertyType.String: return property.stringValue;
                case SerializedPropertyType.Color: return property.colorValue;
                case SerializedPropertyType.LayerMask: return (LayerMask)property.intValue;
                case SerializedPropertyType.Enum: return property.enumValueIndex;
                case SerializedPropertyType.Vector2: return property.vector2Value;
                case SerializedPropertyType.Vector3: return property.vector3Value;
                case SerializedPropertyType.Vector4: return property.vector4Value;
                case SerializedPropertyType.Vector2Int: return property.vector2IntValue;
                case SerializedPropertyType.Vector3Int: return property.vector3IntValue;
                case SerializedPropertyType.Quaternion: return property.quaternionValue;
                case SerializedPropertyType.Rect: return property.rectValue;
                case SerializedPropertyType.RectInt: return property.rectIntValue;
                case SerializedPropertyType.BoundsInt: return property.boundsIntValue;
                case SerializedPropertyType.Bounds: return property.boundsValue;
                case SerializedPropertyType.Character: return (char)property.intValue;
                case SerializedPropertyType.AnimationCurve: return property.animationCurveValue;
                case SerializedPropertyType.FixedBufferSize: return property.fixedBufferSize;
                case SerializedPropertyType.ExposedReference: return property.exposedReferenceValue;
                case SerializedPropertyType.Generic:
                case SerializedPropertyType.Gradient:
                    throw new InvalidOperationException($"Cant handle {property.propertyType} types. for property {property.name}");
                default:
                    throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Determine if a SerializedProperty array contains an int value.
        /// </summary>
        /// <param name="property">The SerializedProperty.</param>
        /// <param name="value">The value to check if it exists.</param>
        /// <returns>True if the int exists in the array, otherwise false.</returns>
        public static bool ArrayContainsInt(this SerializedProperty property, int value)
        {
            if (!property.isArray)
            {
                throw new ArgumentException("property is not an array");
            }

            for (int i = 0; i < property.arraySize; ++i)
            {
                var intVal = property.GetArrayElementAtIndex(i).intValue;
                if (intVal.Equals(value)) return true;
            }

            return false;
        }

        /// <summary>
        /// Helper method to remove an element from a SerializedProperty array. Needed because of quirks using DeleteArrayElementAtIndex.
        /// </summary>
        /// <param name="property">The SerializedProperty.</param>
        /// <param name="index">The index to delete from array.</param>
        public static void RemoveArrayElement(this SerializedProperty property, int index)
        {
            if (!property.isArray)
            {
                throw new ArgumentException("property is not an array");
            }

            // For some reason you need to set objectReferenceValue to null in order to delete an array element from an array.
            var itemProp = property.GetArrayElementAtIndex(index);
            if (itemProp.propertyType == SerializedPropertyType.ObjectReference && itemProp.objectReferenceValue != null)
                itemProp.objectReferenceValue = null;

            // For some reason it is not possible to delete last element in array with DeleteArrayElementAtIndex.
            if (index == property.arraySize - 1)
            {
                property.arraySize--;
            }
            else
            {
                property.DeleteArrayElementAtIndex(index);
            }
        }

        public static object GetParent(this SerializedProperty property)
        {
            var path = property.propertyPath.Replace(".Array.data[", "[");
            object obj = property.serializedObject.targetObject;
            var elements = path.Split('.');
            foreach (var element in elements.Take(elements.Length - 1))
            {
                if (element.Contains("["))
                {
                    var elementName = element.Substring(0, element.IndexOf("["));
                    var index = Convert.ToInt32(element.Substring(element.IndexOf("[")).Replace("[", "").Replace("]", ""));
                    obj = obj.GetValue(elementName, index);
                }
                else
                {
                    obj = obj.GetValue(element);
                }
            }
            return obj;
        }

        public static object GetValue(this object source, string name)
        {
            if (source == null)
                return null;
            var type = source.GetType();
            var f = type.GetField(name, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            if (f == null)
            {
                var p = type.GetProperty(name, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                if (p == null)
                    return null;
                return p.GetValue(source, null);
            }
            return f.GetValue(source);
        }

        public static object GetValue(this object source, string name, int index)
        {
            var enumerable = GetValue(source, name) as IEnumerable;
            var enm = enumerable.GetEnumerator();
            while (index-- >= 0)
                enm.MoveNext();
            return enm.Current;
        }
    }
}
