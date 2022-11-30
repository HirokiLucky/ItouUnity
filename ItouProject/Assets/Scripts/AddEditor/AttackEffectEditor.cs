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
    }
}
