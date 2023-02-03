using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ConvertSpriteToImg))]
public class ECGConvertSpriteToImg : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        ConvertSpriteToImg drawer = (ConvertSpriteToImg)target;
        if (GUILayout.Button("Convert and save Prefab"))
        {
            if (EditorUtility.DisplayDialog("Convert character?",
                "This action will convert the character from sprite to UI.Image", "Confirm", "Cancel"))
            {
                drawer.ConvertToUIIMG();
            }
        }
    }
}
