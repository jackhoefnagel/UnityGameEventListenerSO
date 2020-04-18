using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(GameEventSO))]
public class GameEventListenerEditor : Editor {

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        GameEventSO myScript = (GameEventSO)target;
        if (GUILayout.Button("Raise Event"))
        {
            myScript.Raise();
        }
    }
}
