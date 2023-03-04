using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//敵のスクリプト
public class JackO : MonoBehaviour
{
    private Animator _animator;
    
    public int hpJackO;

    [SerializeField] private GameSystem _gameSystem;
    [SerializeField] private Wizard _wizard;
    
    [SerializeField] private GameObject magicAura;
    [SerializeField] private TextMeshProUGUI hp;
    [SerializeField] private TextMeshProUGUI hpEnemy;
    private ParticleSystem magicAuraParticle;
    
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
        magicAuraParticle = magicAura.GetComponent<ParticleSystem>();
    }
    
    // 死んだ時のプログラム
    public void DeadJackO()
    {
        _animator.SetTrigger(Dead);
    }
    
    // 攻撃受けたときのプログラム
    public void HurtJackO(int wordNum)
    {
        int damage = 0;
        
        // ダメージ計算
        // 回復
        if (wordNum == 5)
        {
            Debug.Log("回復８");
            Debug.Log(_wizard.hpWizard);
            _wizard.hpWizard += 8;
            Debug.Log(_wizard.hpWizard);
            if (_wizard.paralysis) damage -= wordNum - 2;
            else damage -= wordNum;
        }

        // 麻痺
        if (_wizard.paralysis)
        {
            damage -= 2;
            _wizard.paralysis = false;
            _wizard.paralysisUI.SetActive(false);
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
        
        hpJackO -= wordNum + damage;
        Debug.Log(wordNum+ damage + "ダメージジャックは受けた。HP：" + hpJackO);
        hp.text = hpJackO.ToString();
        hpEnemy.text = _wizard.hpWizard.ToString();
        if (hpJackO <= 0)
        {
            Debug.Log("ジャックダウン");
            DeadJackO();
            _gameSystem.GameClear();
            screenButton.SetActive(true);
        }
    }
    
    // 攻撃する時のプログラム
    public void AttackJackO()
    {
        magicAura.SetActive(true);
        magicAuraParticle.Play();
        Invoke("StopParticle",3);
    }

    
    // パーティクル停止
    void StopParticle()
    {
        magicAuraParticle.Stop();
    }
}
