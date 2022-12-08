using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(AttackEffects))]
public class AttackEffectEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        
        AttackEffects attackEffects = target as AttackEffects;

        if (GUILayout.Button("Level2"))
        {
            attackEffects.Level2('り', 2);   
        }
        if (GUILayout.Button("Level3"))
        {
            attackEffects.Level3('り', 2);   
        }
        if (GUILayout.Button("Level4"))
        {
            attackEffects.Level4('り', 2);   
        }
        if (GUILayout.Button("Level5"))
        {
            attackEffects.Level5('り', 2);   
        }
        if (GUILayout.Button("Level6"))
        {
            attackEffects.Level6('り', 2);   
        }
        if (GUILayout.Button("Level7"))
        {
            attackEffects.Level7('り', 2);   
        }
        if (GUILayout.Button("Level8"))
        {
            attackEffects.Level8('り', 2);   
        }
    }
}
