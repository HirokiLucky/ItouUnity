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
    [SerializeField] private GameSystem _gameSystem;

    private void Start()
    {
        bombParticleSystem = bomb.GetComponent<ParticleSystem>();
    }


    // 5番目
    public void Attack(char lastword)
    {
        bomb.SetActive(true);
        bombParticleSystem.Play();
        

        // シーケンス終了OnCompleteで
        _gameSystem.EnemyTurn();
        _enemy.Response(lastword);
    }
    
    // 8番目 => 1番目
    public void Attack()
    {
        bomb.SetActive(true);
        bombParticleSystem.Play();
        
        // シーケンス終了OnCompleteで
        _gameSystem.YourTurn();
    }
}
