using UnityEditor;
using UnityEngine;
public class ReadOnlyProperty : PropertyAttribute { }

[CustomPropertyDrawer(typeof(ReadOnlyProperty))]
public class ReadOnlyPropertyDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        GUI.enabled = false;
        EditorGUI.PropertyField(position, property, label);
        GUI.enabled = true;
    }
}