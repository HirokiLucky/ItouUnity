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
            attackEffects.Level2();   
        }
        if (GUILayout.Button("Level3"))
        {
            attackEffects.Level3();   
        }
        if (GUILayout.Button("Level4"))
        {
            attackEffects.Level4();   
        }
        if (GUILayout.Button("Level5"))
        {
            attackEffects.Level5();   
        }
        if (GUILayout.Button("Level6"))
        {
            attackEffects.Level6();   
        }
        if (GUILayout.Button("Level7"))
        {
            attackEffects.Level7();   
        }
        if (GUILayout.Button("Level8"))
        {
            attackEffects.Level8();   
        }
    }
}
