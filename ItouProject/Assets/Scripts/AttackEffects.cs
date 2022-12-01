using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class AttackEffects : MonoBehaviour
{
    [SerializeField] private GameObject bomb;
    private ParticleSystem bombParticleSystem;
    [SerializeField] private GameObject magicAura;
    private ParticleSystem magicAuraParticle;
    [SerializeField] private GameObject magicLight;
    private ParticleSystem magicLightParticle;

    [SerializeField] private Enemy _enemy;
    [SerializeField] private Wizard _wizard;
    [SerializeField] private JackO _jackO;
    [SerializeField] private GameSystem _gameSystem;

    [SerializeField] private GameObject ps1;
    [SerializeField] private GameObject ps2;
    private ParticleSystem ps1Particle;
    private ParticleSystem ps2Particle;
    
    [SerializeField] private GameObject ps3;
    [SerializeField] private GameObject ps4;
    private ParticleSystem ps3Particle;
    private ParticleSystem ps4Particle;
    
    [SerializeField] private GameObject ps5;
    [SerializeField] private GameObject ps6;
    private ParticleSystem ps5Particle;
    private ParticleSystem ps6Particle;

    private Vector2 wizardPos = new Vector2(-6, -3.1f);
    private Vector2 JackOPos = new Vector2(6, -3.2f);
    

    private void Start()
    {
        bombParticleSystem = bomb.GetComponent<ParticleSystem>();
        magicAuraParticle = magicAura.GetComponent<ParticleSystem>();
        magicLightParticle = magicAura.GetComponent<ParticleSystem>();
        ps1Particle = ps1.GetComponent<ParticleSystem>();
        ps2Particle = ps2.GetComponent<ParticleSystem>();
        ps3Particle = ps3.GetComponent<ParticleSystem>();
        ps4Particle = ps4.GetComponent<ParticleSystem>();
        ps5Particle = ps5.GetComponent<ParticleSystem>();
        ps6Particle = ps6.GetComponent<ParticleSystem>();
    }


    // 5番目
    // プレイヤーのエフェクト
    public void Attack(char lastword, int wordCount)
    {
        _wizard.AttackWizard();
        
        WizardMagic();
        
        bomb.SetActive(true);
        bombParticleSystem.Play();
        
        _jackO.HurtJackO(1);
        
        // シーケンス終了OnCompleteで
        _gameSystem.EnemyTurn();
        _enemy.Response(lastword, wordCount);
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
    
    
    void Effectmanager(int wordNum)
    {
        switch (wordNum)
        {
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            case 8:
                break;
            default:
                Debug.Log("a");
                break;
        }
    }
    void WizardMagic()
    {
        magicAura.SetActive(true);
        magicLight.SetActive(true);
        magicAuraParticle.Play();
        magicLightParticle.Play();
    }

    public void Level2()
    {
        WizardMagic();
        ps1.transform.position = JackOPos;
        ps2.transform.position = JackOPos;
        ps1.SetActive(true);
        ps2.SetActive(true);
        ps1Particle.Play();
        ps2Particle.Play();
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(ps2.transform.DOMove(new Vector3(2,2), 1).SetEase(Ease.OutExpo)).SetRelative(true);
    }
    
    public void Level3()
    {
        WizardMagic();
        ps3.transform.position = wizardPos + new Vector2(2, 1);
        ps4.transform.position = JackOPos + new Vector2(0, 3);
        ps3.SetActive(true);
        ps3Particle.Play();
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(ps3.transform.DOMove(JackOPos, 3).SetEase(Ease.InExpo))
            .AppendCallback(() =>
            {
                ps4.SetActive(true);
                ps4Particle.Play();
            })
            .Append(ps3.transform.DOMoveX(10, 1))
            .OnComplete(() => ps3.SetActive(false));
    }
    
    public void Level4()
    {
        WizardMagic();
        ps5.transform.position = wizardPos + new Vector2(2, 2);
        ps6.transform.position = JackOPos;
        ps5.SetActive(true);
        ps5Particle.Play();
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(ps5.transform.DOMove(JackOPos, 4))
            .AppendCallback(() =>
            {
                ps6.SetActive(true);
                ps6Particle.Play();
            })
            .OnComplete(() => ps5.SetActive(false));;
    }
    
    public void Level5()
    {
        WizardMagic();
        ps1.transform.position = JackOPos;
        ps2.transform.position = JackOPos;
        ps1.SetActive(true);
        ps2.SetActive(true);
        ps1Particle.Play();
        ps2Particle.Play();
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(ps2.transform.DOMove(new Vector3(2,2), 1).SetEase(Ease.OutExpo)).SetRelative(true);
    }
    
    public void Level6()
    {
        Debug.Log("aa");
        WizardMagic();
        ps1.transform.position = JackOPos;
        ps2.transform.position = JackOPos;
        ps1.SetActive(true);
        ps2.SetActive(true);
        ps1Particle.Play();
        ps2Particle.Play();
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(ps2.transform.DOMove(new Vector3(2,2), 1).SetEase(Ease.OutExpo)).SetRelative(true);
    }
    
    public void Level7()
    {
        Debug.Log("aa");
        WizardMagic();
        ps1.transform.position = JackOPos;
        ps2.transform.position = JackOPos;
        ps1.SetActive(true);
        ps2.SetActive(true);
        ps1Particle.Play();
        ps2Particle.Play();
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(ps2.transform.DOMove(new Vector3(2,2), 1).SetEase(Ease.OutExpo)).SetRelative(true);
    }
    
    public void Level8()
    {
        Debug.Log("aa");
        WizardMagic();
        ps1.transform.position = JackOPos;
        ps2.transform.position = JackOPos;
        ps1.SetActive(true);
        ps2.SetActive(true);
        ps1Particle.Play();
        ps2Particle.Play();
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(ps2.transform.DOMove(new Vector3(2,2), 1).SetEase(Ease.OutExpo)).SetRelative(true);
    }

    
}
