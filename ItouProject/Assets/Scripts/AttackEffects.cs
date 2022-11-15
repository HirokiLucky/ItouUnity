using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEffects : MonoBehaviour
{
    [SerializeField] private GameObject bomb;

    [SerializeField] private Enemy _enemy;
    [SerializeField] private Wizard _wizard;

    public void Attack(char lastword)
    {
        bomb.SetActive(true);
        
        
        
        // シーケンス終了OnCompleteで
        _enemy.Response(lastword);
    }
    
    
    public void Attack()
    {
        bomb.SetActive(true);
        
        // シーケンス終了OnCompleteで
        _wizard.WizardTurn();
    }
}
