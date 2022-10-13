using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ArrayViewer))]
public class MultiDarrayInspector : Editor
{
    ArrayViewer targetScript;

    void OnEnable()
    {
        targetScript = target as ArrayViewer;
    }

    public override void OnInspectorGUI()
    {

        ArrayViewer.X = EditorGUILayout.IntField(ArrayViewer.X);
        ArrayViewer.Y = EditorGUILayout.IntField(ArrayViewer.Y);

        EditorGUILayout.BeginHorizontal();
        for (int y = 0; y < ArrayViewer.Y; y++)
        {
            EditorGUILayout.BeginVertical();
            for (int x = 0; x < ArrayViewer.X; x++)
            {

                targetScript.columns[x].rows[y] = EditorGUILayout.Toggle(targetScript.columns[x].rows[y]);
            }
            EditorGUILayout.EndVertical();

        }
        EditorGUILayout.EndHorizontal();

    }

}

