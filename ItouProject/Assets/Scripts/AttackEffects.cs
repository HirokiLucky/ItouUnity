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
    public void Attack(char lastword)
    {
        _wizard.AttackWizard();
        
        bomb.SetActive(true);
        bombParticleSystem.Play();
        
        _jackO.HurtJackO(1);
        
        // シーケンス終了OnCompleteで
        _gameSystem.EnemyTurn();
        _enemy.Response(lastword);
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
}
