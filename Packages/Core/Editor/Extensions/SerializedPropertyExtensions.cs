using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    internal static class SerializedPropertyExtensions
    {

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

        public static object GetPropertyValue(this SerializedProperty property)
        {
            if (property == null) throw new ArgumentNullException(nameof(property));
            switch(property.propertyType)
            {
                case SerializedPropertyType.ObjectReference: return property.objectReferenceValue;
                case SerializedPropertyType.ArraySize: return property.arraySize;
                case SerializedPropertyType.Integer: return property.intValue;
                case SerializedPropertyType.Boolean: return property.boolValue;
                case SerializedPropertyType.Float:  return property.floatValue;
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
                    throw new InvalidOperationException($"Cant handle {property.propertyType} types. for property {property.name}");
                case SerializedPropertyType.Gradient:
                    throw new InvalidOperationException($"Cant handle {property.propertyType} types. for property {property.name}");
                default:
                    throw new NotImplementedException();
            }
        }

    }
}
