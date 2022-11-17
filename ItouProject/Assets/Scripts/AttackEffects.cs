using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEffects : MonoBehaviour
{
    [SerializeField] private GameObject bomb;

    [SerializeField] private Enemy _enemy;
    [SerializeField] private Wizard _wizard;

    
    // 5番目
    public void Attack(char lastword)
    {
        bomb.SetActive(true);

        // シーケンス終了OnCompleteで
        _enemy.Response(lastword);
    }
    
    // 8番目 => 1番目
    public void Attack()
    {
        bomb.SetActive(true);
        
        // シーケンス終了OnCompleteで
        _wizard.WizardTurn();
    }
}
