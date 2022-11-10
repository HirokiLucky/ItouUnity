using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JackO : MonoBehaviour
{
    [SerializeField] private GameObject jackO;
    private Animator _animator;
    private static readonly int Dead = Animator.StringToHash("Dead");


    void Start()
    {
        _animator = jackO.GetComponent<Animator>();
    }
    

    public void DeadJackO()
    {
        _animator.SetTrigger(Dead);
    }
}
