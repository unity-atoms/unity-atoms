using System;
using System.CodeDom;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    internal static class SerializedPropertyExtensions
    {

        // should probably be somewhere else:
        public static bool       ValueLayoutField(string label, bool value      ) => EditorGUILayout.Toggle(label, value);
        public static int        ValueLayoutField(string label, int value       ) => EditorGUILayout.IntField(label, value);
        public static float      ValueLayoutField(string label, float value     ) => EditorGUILayout.FloatField(label, value);
        public static double     ValueLayoutField(string label, double value    ) => EditorGUILayout.DoubleField(label, value);
        public static long       ValueLayoutField(string label, long value      ) => EditorGUILayout.LongField(label, value);
        public static string     ValueLayoutField(string label, string value    ) => EditorGUILayout.TextField(label, value);
        public static Vector2    ValueLayoutField(string label, Vector2 value   ) => EditorGUILayout.Vector2Field(label, value);
        public static Vector3    ValueLayoutField(string label, Vector3 value   ) => EditorGUILayout.Vector3Field(label, value);
        public static Vector4    ValueLayoutField(string label, Vector4 value   ) => EditorGUILayout.Vector4Field(label, value);
        public static Vector2Int ValueLayoutField(string label, Vector2Int value) => EditorGUILayout.Vector2IntField(label, value);
        public static Vector3Int ValueLayoutField(string label, Vector3Int value) => EditorGUILayout.Vector3IntField(label, value);
        public static Bounds     ValueLayoutField(string label, Bounds value    ) => EditorGUILayout.BoundsField(label, value);
        public static BoundsInt  ValueLayoutField(string label, BoundsInt value ) => EditorGUILayout.BoundsIntField(label, value);
        public static Rect       ValueLayoutField(string label, Rect value      ) => EditorGUILayout.RectField(label, value);
        public static RectInt    ValueLayoutField(string label, RectInt value   ) => EditorGUILayout.RectIntField(label, value);
        public static Color      ValueLayoutField(string label, Color value     ) => EditorGUILayout.ColorField(label, value);

        public static T ValueLayoutField<T>(string label, T value) where T : UnityEngine.Object{
            return (T)EditorGUILayout.ObjectField(label, value, typeof(T), true);
        }

        public static object ValueLayoutField(string label, object value)
        {
            EditorGUILayout.LabelField("Not supported for 'object'-Type");
            return value;
        }



        public static T GetValue<T>(this SerializedProperty property)
        {
            switch (typeof(T))
            {
                //possibly boxing :(  (built-in native types)
                case var cls when cls == typeof(bool): return (T)(object)property.boolValue;
                case var cls when cls == typeof(int): return (T)(object)property.intValue;
                case var cls when cls == typeof(float): return (T)(object)property.floatValue;
                case var cls when cls == typeof(double): return (T)(object)property.doubleValue;
                case var cls when cls == typeof(long): return (T)(object)property.longValue;

                //possibly boxing :(
                case var cls when cls == typeof(Vector2): return (T)(object)property.vector2Value;
                case var cls when cls == typeof(Vector3): return (T)(object)property.vector3Value;
                case var cls when cls == typeof(Vector4): return (T)(object)property.vector4Value;
                case var cls when cls == typeof(Quaternion): return (T)(object)property.quaternionValue;
                case var cls when cls == typeof(Vector2Int): return (T)(object)property.vector2IntValue;
                case var cls when cls == typeof(Vector3Int): return (T)(object)property.vector3IntValue;
                case var cls when cls == typeof(Bounds): return (T)(object)property.boundsValue;
                case var cls when cls == typeof(Rect): return (T)(object)property.rectValue;
                case var cls when cls == typeof(Color): return (T)(object)property.colorValue;

                //ref types
                case var cls when cls == typeof(string): return (T)(object)property.stringValue;
                case var cls when cls == typeof(object): return (T)(object)property.objectReferenceValue;
            }

            return default(T);
        }

    }
}
