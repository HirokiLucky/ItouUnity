using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    private Animator _animator;

    [SerializeField] private GameSystem _gameSystem;

    public int hpWizard = 10;

    [SerializeField] private TextMeshProUGUI hp;

    
    
    private static readonly int Dead = Animator.StringToHash("Dead");
    private static readonly int Hurt = Animator.StringToHash("Hurt");
    private static readonly int Attack = Animator.StringToHash("Attack");
    
    [SerializeField] private GameObject screenButton;


    void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
        
    }
    

    public void DeadWizard()
    {
        _animator.SetTrigger(Dead);
    }

    public void HurtWizard(int damage)
    {
        _animator.SetTrigger(Hurt);
        hpWizard -= damage;
        Debug.Log(damage + "ダメージ魔法使いは受けた。HP：" + hpWizard);
        hp.text = hpWizard.ToString();
        if (hpWizard <= 0)
        {
            Debug.Log("魔法使いダウン");
            DeadWizard();
            _gameSystem.GameOver();
            screenButton.SetActive(true);
        }
    }
    
    
    // 攻撃時の関数
    public void AttackWizard()
    {
        _animator.SetTrigger(Attack);
    }
    
    
}
