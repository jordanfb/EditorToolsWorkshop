using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MarbleScript))]
public class MarbleGUI : Editor {

    public override void OnInspectorGUI()
    {
        MarbleScript ms = (MarbleScript)target;
        // healthBar.currentHealth = EditorGUILayout.Slider("Current Health", healthBar.currentHealth, 0, healthBar.maxHealth);
        //serializedObject.Update();
        EditorGUI.BeginChangeCheck();
        ms.radius = EditorGUILayout.Slider("Radius", ms.radius, 0, 100);
        DrawDefaultInspector();

        if (EditorGUI.EndChangeCheck())
        {
            Debug.Log("something changed");
            // rebuild the art and scale
        }
    }
}
