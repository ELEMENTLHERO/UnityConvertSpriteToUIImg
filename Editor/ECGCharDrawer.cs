using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(CharDrawer))]
public class ECGCharDrawer : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        CharDrawer drawer = (CharDrawer)target;
        if (GUILayout.Button("Convert and save Prefab"))
        {
            if (EditorUtility.DisplayDialog("Convert character?",
                "This action will convert the character from sprite to UI.Image", "Confirm", "Cancel"))
            {
                drawer.ConvertCharToUIIMG();
            }
        }
    }
}
