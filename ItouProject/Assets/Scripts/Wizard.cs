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

    public int hpWizard = 10;

    [SerializeField] private TextMeshProUGUI hp;

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
    

    public void DeadWizard()
    {
        _animator.SetTrigger(Dead);
    }

    public void HurtWizard(int wordNum)
    {
        int damage = 0;
        _animator.SetTrigger(Hurt);
        
        // ダメージ計算
        // 回復
        if (wordNum == 5)
        {
            hpWizard += 8;
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
        if (fire != 0)
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
            Debug.Log("呪い発動：５ダメージ増加");
        }
        
        hpWizard -= wordNum + damage;
        Debug.Log(wordNum + damage + "ダメージ魔法使いは受けた。HP：" + hpWizard);
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
