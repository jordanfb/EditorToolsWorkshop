using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(WallScript))]
public class MeshDrawer : Editor {

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        //for (int i = 0; i < serializedObject.)

        DrawDefaultInspector();
    }

    void OnSceneGUI()
    {
        WallScript example = (WallScript)target;
        EditorGUI.BeginChangeCheck();
        for (int i = 0; i < example.meshPoints.Length; i++)
        {
            example.meshPoints[i] = Handles.PositionHandle(example.meshPoints[i], Quaternion.identity);
        }
        if (EditorGUI.EndChangeCheck())
        {
            example.SetMesh();
        }
    }
}
