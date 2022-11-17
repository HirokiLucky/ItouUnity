using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    private Animator _animator;

    public int hpWizard = 10;

    [SerializeField] private GameObject magicAura;
    private ParticleSystem magicAuraParticle;
    
    private static readonly int Dead = Animator.StringToHash("Dead");
    private static readonly int Hurt = Animator.StringToHash("Hurt");
    private static readonly int Attack = Animator.StringToHash("Attack");
    
    


    void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
        magicAuraParticle = magicAura.GetComponent<ParticleSystem>();
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
        if (hpWizard <= 0)
        {
            Debug.Log("魔法使いダウン");
        }
    }
    
    public void AttackWizard()
    {
        _animator.SetTrigger(Attack);
        magicAura.SetActive(true);
        magicAuraParticle.Play();
    }
    
    
}
