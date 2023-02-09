using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//敵のスクリプト
public class JackO : MonoBehaviour
{
    private Animator _animator;
    
    public int hpJackO = 10;

    [SerializeField] private GameSystem _gameSystem;
    
    [SerializeField] private GameObject magicAura;
    [SerializeField] private TextMeshProUGUI hp;
    private ParticleSystem magicAuraParticle;
    
    private static readonly int Dead = Animator.StringToHash("Dead");
    private static readonly int Hurt = Animator.StringToHash("Hurt");
    private static readonly int Attack = Animator.StringToHash("Attack");


    void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
        magicAuraParticle = magicAura.GetComponent<ParticleSystem>();
    }
    
    public void DeadJackO()
    {
        _animator.SetTrigger(Dead);
    }
    
    public void HurtJackO(int damage)
    {
        hpJackO -= damage;
        Debug.Log(damage + "ダメージジャックは受けた。HP：" + hpJackO);
        hp.text = hpJackO.ToString();
        if (hpJackO <= 0)
        {
            Debug.Log("ジャックダウン");
            DeadJackO();
            _gameSystem.GameClear();
        }
    }
    
    public void AttackJackO()
    {
        magicAura.SetActive(true);
        magicAuraParticle.Play();
        Invoke("StopParticle",3);
    }

    void StopParticle()
    {
        magicAuraParticle.Stop();
    }
}
