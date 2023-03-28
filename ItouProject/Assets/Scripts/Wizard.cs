using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    private Animator _animator;

    [SerializeField] private GameSystem _gameSystem;
    [SerializeField] private JackO _jackO;
    [SerializeField] private AttackEffects _attackEffects;
 
    public int hpWizard;

    [SerializeField] private TextMeshProUGUI hp;
    [SerializeField] private TextMeshProUGUI hpEnemy;

    public bool paralysis = false;
    public int fire = 0;
    public int spell = -1;
    public GameObject paralysisUI;
    public GameObject fireUI;
    public GameObject spellUI;

    private static readonly int Dead = Animator.StringToHash("Dead");
    private static readonly int Hurt = Animator.StringToHash("Hurt");
    private static readonly int Attack = Animator.StringToHash("Attack");
    
    [SerializeField] private GameObject screenButton;


    void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
    }
    
    // 死んだ時のプログラム
    public void DeadWizard()
    {
        _animator.SetTrigger(Dead);
    }

    // 攻撃を受けた時のプログラム
    public void HurtWizard(int wordNum)
    {
        _animator.SetTrigger(Hurt);
        
        // 回復
        if (wordNum == 5)
        {
            Debug.Log("回復5");
            _jackO.hpJackO += 5;
        }

        hpWizard -= _attackEffects.totalDamage;
        Debug.Log(_attackEffects.totalDamage + "ダメージ魔法使いは受けた。HP：" + hpWizard);
        hp.text = hpWizard.ToString();
        hpEnemy.text = _jackO.hpJackO.ToString();
        if (hpWizard <= 0)
        {
            Debug.Log("魔法使いダウン");
            DeadWizard();
            _gameSystem.GameOver();
            screenButton.SetActive(true);
        }
    }

    // ダメージ計算
    public int DamageCul(int wordNum)
    {
        int damage = 0;
        
        // ダメージ計算
        // 回復
        if (wordNum == 5)
        {
            _jackO.paralysis = false;
            _jackO.fire = 0;
            _jackO.spell = -1;
            _jackO.paralysisUI.SetActive(false);
            _jackO.fireUI.SetActive(false);
            _jackO.spellUI.SetActive(false);
            if (_jackO.paralysis) damage -= wordNum - 2;
            else damage -= wordNum;
        }
        
        // 麻痺
        if (_jackO.paralysis)
        {
            damage -= 2;
            _jackO.paralysis = false;
            _jackO.paralysisUI.SetActive(false);
            Debug.Log("麻痺発動：２ダメージ軽減");
        }
        
        // 炎症
        if (fire == 1)
        {
            damage += 2;
            fire--;
            fireUI.SetActive(false);
            Debug.Log("炎症発動：２ダメージ増加");
        } else if (fire != 0)
        {
            damage += 2;
            fire--;
            Debug.Log("炎症発動：２ダメージ増加");
        }

        // 呪い
        if (spell > 0)
        {
            spell--;
        } else if (spell == 0)
        {
            damage += 5;
            spell--;
            spellUI.SetActive(false);
            Debug.Log("呪い発動：５ダメージ増加");
        }

        return damage;
    }
    
    // 攻撃時の関数
    public void AttackWizard()
    {
        _animator.SetTrigger(Attack);
    }
}
