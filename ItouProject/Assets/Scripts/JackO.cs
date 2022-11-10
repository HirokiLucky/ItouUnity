using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JackO : MonoBehaviour
{
    [SerializeField] private GameObject jackO;
    private Animator _animator;
    
    private static readonly int Dead = Animator.StringToHash("Dead");
    private static readonly int Hurt = Animator.StringToHash("Hurt");
    private static readonly int Attack = Animator.StringToHash("Attack");


    void Start()
    {
        _animator = jackO.GetComponent<Animator>();
    }
    

    public void DeadJackO()
    {
        _animator.SetTrigger(Dead);
    }
    
    public void HurtJackO()
    {
        _animator.SetTrigger(Hurt);
    }
    
    public void AttackJackO()
    {
        _animator.SetTrigger(Attack);
    }
}
