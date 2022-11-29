using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEffects : MonoBehaviour
{
    [SerializeField] private GameObject bomb;
    private ParticleSystem bombParticleSystem;

    [SerializeField] private Enemy _enemy;
    [SerializeField] private Wizard _wizard;
    [SerializeField] private JackO _jackO;
    [SerializeField] private GameSystem _gameSystem;

    private void Start()
    {
        bombParticleSystem = bomb.GetComponent<ParticleSystem>();
    }


    // 5番目
    // プレイヤーのエフェクト
    public void Attack(char lastword, int wordCount)
    {
        _wizard.AttackWizard();
        
        bomb.SetActive(true);
        bombParticleSystem.Play();
        
        _jackO.HurtJackO(1);
        
        // シーケンス終了OnCompleteで
        _gameSystem.EnemyTurn();
        _enemy.Response(lastword, wordCount);
    }
    
    // 8番目 => 1番目
    // 敵のエフェクト
    public void Attack()
    {
        _jackO.AttackJackO();
        
        bomb.SetActive(true);
        bombParticleSystem.Play();
        
        _wizard.HurtWizard(1);
        
        // シーケンス終了OnCompleteで
        _gameSystem.YourTurn();
    }
    
    
    void Effectmanager(int wordNum)
    {
        switch (wordNum)
        {
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            case 8:
                break;
            default:
                Debug.Log("a");
                break;
        }
    }
}
