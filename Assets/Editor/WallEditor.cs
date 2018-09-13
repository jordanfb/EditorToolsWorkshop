using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(WallScript))]
public class WallEditor : Editor {
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        WallScript wall = (WallScript)target;
        // wall.meshPoints;
        EditorGUILayout.Slider(5, 0, 100);
    }

    public void OnSceneGUI()
    {
        WallScript wall = (WallScript)target;
        EditorGUI.BeginChangeCheck();
        for (int i = 0; i < wall.meshPoints.Length; i++)
        {
            wall.meshPoints[i] = Handles.PositionHandle(wall.transform.position + (Vector3)wall.meshPoints[i], Quaternion.identity) - wall.transform.position;
        }

        

        if (EditorGUI.EndChangeCheck())
        {
            wall.SetMesh();
        }
    }
}
