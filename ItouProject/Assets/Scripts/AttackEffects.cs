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

    #region Effect

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
    
    [SerializeField] private GameObject ps7;
    [SerializeField] private GameObject ps8;
    [SerializeField] private GameObject ps9;
    private ParticleSystem ps7Particle;
    private ParticleSystem ps8Particle;
    private ParticleSystem ps9Particle;
    
    [SerializeField] private GameObject ps10;
    [SerializeField] private GameObject ps11;
    [SerializeField] private GameObject ps12;
    private ParticleSystem ps10Particle;
    private ParticleSystem ps11Particle;
    private ParticleSystem ps12Particle;
    
    [SerializeField] private GameObject ps13;
    [SerializeField] private GameObject ps14;
    [SerializeField] private GameObject ps15;
    [SerializeField] private GameObject ps16;
    private ParticleSystem ps13Particle;
    private ParticleSystem ps14Particle;
    private ParticleSystem ps15Particle;
    private ParticleSystem ps16Particle;
    
    [SerializeField] private GameObject ps17;
    [SerializeField] private GameObject ps18;
    [SerializeField] private GameObject ps19;
    [SerializeField] private GameObject ps20;
    [SerializeField] private GameObject ps21;
    [SerializeField] private GameObject ps22;
    [SerializeField] private GameObject ps23;
    [SerializeField] private GameObject ps24;
    [SerializeField] private GameObject ps25;
    [SerializeField] private GameObject ps26;
    private ParticleSystem ps17Particle;
    private ParticleSystem ps18Particle;
    private ParticleSystem ps19Particle;
    private ParticleSystem ps20Particle;
    private ParticleSystem ps21Particle;
    private ParticleSystem ps22Particle;
    private ParticleSystem ps23Particle;
    private ParticleSystem ps24Particle;
    private ParticleSystem ps25Particle;
    private ParticleSystem ps26Particle;
    
    #endregion
    
    private Vector2 wizardPos = new Vector2(-6, -3.1f);
    private Vector2 JackOPos = new Vector2(6, -3.2f);
    private Vector2 JackOCamera = new Vector2(6, 2);
    private Vector3 origin = new Vector3(0, -5, -1);

    private float hitStopTimer = 0f;

    [SerializeField] private GameObject _cameraObject;
    private Camera _camera;

    private void Start()
    {
        _camera = _cameraObject.GetComponent<Camera>();
        bombParticleSystem = bomb.GetComponent<ParticleSystem>();
        magicAuraParticle = magicAura.GetComponent<ParticleSystem>();
        magicLightParticle = magicAura.GetComponent<ParticleSystem>();
        ps1Particle = ps1.GetComponent<ParticleSystem>();
        ps2Particle = ps2.GetComponent<ParticleSystem>();
        ps3Particle = ps3.GetComponent<ParticleSystem>();
        ps4Particle = ps4.GetComponent<ParticleSystem>();
        ps5Particle = ps5.GetComponent<ParticleSystem>();
        ps6Particle = ps6.GetComponent<ParticleSystem>();
        ps7Particle = ps7.GetComponent<ParticleSystem>();
        ps8Particle = ps8.GetComponent<ParticleSystem>();
        ps9Particle = ps9.GetComponent<ParticleSystem>();
        ps10Particle = ps10.GetComponent<ParticleSystem>();
        ps11Particle = ps11.GetComponent<ParticleSystem>();
        ps12Particle = ps12.GetComponent<ParticleSystem>();
        ps13Particle = ps13.GetComponent<ParticleSystem>();
        ps14Particle = ps14.GetComponent<ParticleSystem>();
        ps15Particle = ps15.GetComponent<ParticleSystem>();
        ps16Particle = ps16.GetComponent<ParticleSystem>();
        ps17Particle = ps17.GetComponent<ParticleSystem>();
        ps18Particle = ps18.GetComponent<ParticleSystem>();
        ps19Particle = ps19.GetComponent<ParticleSystem>();
        ps20Particle = ps20.GetComponent<ParticleSystem>();
        ps21Particle = ps21.GetComponent<ParticleSystem>();
        ps22Particle = ps22.GetComponent<ParticleSystem>();
        ps23Particle = ps23.GetComponent<ParticleSystem>();
        ps24Particle = ps24.GetComponent<ParticleSystem>();
        ps25Particle = ps25.GetComponent<ParticleSystem>();
        ps26Particle = ps26.GetComponent<ParticleSystem>();

    }
    
    void Update()
    {
        if (hitStopTimer > 0f)
        {
            Time.timeScale = 0.01f;
            hitStopTimer -= Time.deltaTime;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    void FinishEffect(char lastword, int wordCount)
    {
        _jackO.HurtJackO(wordCount);
        _gameSystem.EnemyTurn();
        _enemy.Response(lastword, wordCount);
    }

    // 5番目
    // プレイヤーのエフェクト
    public void Attack(char lastword, int wordCount)
    {
        _wizard.AttackWizard();
        WizardMagic();
        Sequence sequence = DOTween.Sequence();
        sequence
            .AppendInterval(2)
            .AppendCallback(() =>
            {
                Effectmanager(lastword,wordCount);
            });
    }
    
    // 8番目 => 1番目
    // 敵のエフェクト
    public void Attack(int wordCount)
    {
        _jackO.AttackJackO();
        
        
        bomb.SetActive(true);
        bombParticleSystem.Play();
        
        _wizard.HurtWizard(wordCount);
        
        // シーケンス終了OnCompleteで
        _gameSystem.YourTurn();
    }
    
    
    // 実装する
    void Effectmanager(char lastword,int wordNum)
    {
        switch (wordNum)
        {
            case 2:
                Level2(lastword, wordNum);
                break;
            case 3:
                Level3(lastword, wordNum);
                break;
            case 4:
                Level4(lastword, wordNum);
                break;
            case 5:
                Level5(lastword, wordNum);
                break;
            case 6:
                Level6(lastword, wordNum);
                break;
            case 7:
                Level7(lastword, wordNum);
                break;
            case 8:
                Level8(lastword, wordNum);
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

    public void Level2(char lastword,int wordNum)
    {
        WizardMagic();
        ps1.transform.position = JackOPos;
        ps2.transform.position = JackOPos;
        _camera.DOOrthoSize(3, 1f);
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(_cameraObject.transform.DOMove(JackOCamera, 1))
            .AppendCallback(() =>
            {
                ps1.SetActive(true);
                ps2.SetActive(true);
                ps1Particle.Play();
                ps2Particle.Play();
            })
            .Append(ps2.transform.DOMove(new Vector3(2,2), 1).SetEase(Ease.OutExpo)).SetRelative(true)
            .OnComplete(() =>
            {
                FinishEffect(lastword, wordNum);
                _cameraObject.transform.DOMove(origin, 1);
                _camera.DOOrthoSize(5, 1f);
            });
    }
    
    public void Level3(char lastword,int wordNum)
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
                hitStopTimer = 0.01f;
            })
            .Append(ps3.transform.DOMoveX(10, 1))
            .OnComplete(() =>
            {
                ps3.SetActive(false);
                FinishEffect(lastword, wordNum);
            });
    }
    
    public void Level4(char lastword,int wordNum)
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
            .AppendInterval(0.5f)
            .AppendCallback(() => hitStopTimer = 0.02f)
            .OnComplete(() =>
            {
                ps5.SetActive(false);
                FinishEffect(lastword, wordNum);
            });;
    }
    
    public void Level5(char lastword,int wordNum)
    {
        WizardMagic();
        ps7.transform.position = wizardPos;
        ps8.transform.position = wizardPos;
        ps9.transform.position = wizardPos;

        ps7.SetActive(true);
        ps7Particle.Play();
        ps8.SetActive(true);
        ps8Particle.Play();
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(ps7.transform.DOMoveY(4, 3).SetEase(Ease.OutSine)).SetRelative(true)
            .Append(ps7.transform.DOMoveY(-4, 2).SetEase(Ease.InQuad)).SetRelative(true)
            .AppendCallback(() =>
            {
                ps7.SetActive(false);
                ps8.SetActive(false);
                ps9.SetActive(true);
                ps9Particle.Play();
            })
            .Append(ps9.transform.DOMoveY(2, 2).SetEase(Ease.OutSine)).SetRelative(true)
            .OnComplete(() => FinishEffect(lastword, wordNum));
    }
    
    public void Level6(char lastword,int wordNum)
    {
        WizardMagic();
        ps10.transform.position = wizardPos + new Vector2(2,2);
        ps11.transform.position = wizardPos + new Vector2(4,2);
        ps12.transform.position = JackOPos;

        ps10.SetActive(true);
        ps10Particle.Play();
        ps11.SetActive(true);
        ps11Particle.Play();
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(ps11.transform.DOScale(new Vector3(2,2), 3))
            .Append(ps11.transform.DOMove(JackOPos, 3))
            .AppendCallback(() =>
            {
                
                ps11.SetActive(false);
                ps12.SetActive(true);
                ps12Particle.Play();
            })
            .AppendInterval(1)
            .AppendCallback(() =>
            {
                hitStopTimer = 0.02f;
                ps10.SetActive(false);
                FinishEffect(lastword, wordNum);
            });
    }
    
    public void Level7(char lastword,int wordNum)
    {
        WizardMagic();
        ps13.transform.position = wizardPos;
        ps14.transform.position = JackOPos + new Vector2(0,2);
        ps15.transform.position = JackOPos + new Vector2(0,2);
        ps16.transform.position = new Vector3(6,-4,10);

        ps13.SetActive(true);
        ps13Particle.Play();
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(ps13.transform.DOMove(JackOPos + new Vector2(0,2), 5))
            .AppendCallback(() =>
            {
                ps14.SetActive(true);
                ps14Particle.Play();
                ps15.SetActive(true);
                ps15Particle.Play();
                ps13.SetActive(false);
            })
            .AppendInterval(1)
            .AppendCallback(() =>
            {
                ps16.SetActive(true);
                ps16Particle.Play();
            })
            .AppendInterval(2)
            .OnComplete(() =>
            {
                ps15.SetActive(false);
                ps16.SetActive(false);
                FinishEffect(lastword, wordNum);
            });
    }
    
    public void Level8(char lastword,int wordNum)
    {
        WizardMagic();
        Vector2 grond = new Vector2(6, -4);
        ps17.transform.position = wizardPos;
        ps18.transform.position = wizardPos;
        ps19.transform.position = wizardPos;
        ps20.transform.position = wizardPos;
        ps21.transform.position = wizardPos;
        ps22.transform.position = grond;
        ps23.transform.position = grond;
        ps24.transform.position = grond;
        ps25.transform.position = grond;
        ps26.transform.position = grond;
        ps17.SetActive(true);
        ps18.SetActive(true);
        ps19.SetActive(true);
        ps20.SetActive(true);
        ps21.SetActive(true);
        ps17Particle.Play();
        ps18Particle.Play();
        ps19Particle.Play();
        ps20Particle.Play();
        ps21Particle.Play();
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(ps17.transform.DOMove( JackOPos + new Vector2(0,4), 2))
            .Join(ps18.transform.DOMove( JackOPos + new Vector2(4,0), 2))
            .Join(ps19.transform.DOMove( JackOPos + new Vector2(-4,0), 2))
            .Join(ps20.transform.DOMove( JackOPos + new Vector2(2,2), 2))
            .Join(ps21.transform.DOMove( JackOPos + new Vector2(-2,2), 2))
            .Append(ps17.transform.DOMove( JackOPos, 1))
            .AppendCallback(() =>
            {
                ps22.SetActive(true);
                ps22Particle.Play();
            })
            .Append(ps18.transform.DOMove( JackOPos, 1))
            .AppendCallback(() =>
            {
                ps23.SetActive(true);
                ps23Particle.Play();
            })
            .Append(ps19.transform.DOMove( JackOPos, 1))
            .AppendCallback(() =>
            {
                ps24.SetActive(true);
                ps24Particle.Play();
            })
            .Append(ps20.transform.DOMove( JackOPos, 1))
            .AppendCallback(() =>
            {
                ps25.SetActive(true);
                ps25Particle.Play();
            })
            .Append(ps21.transform.DOMove( JackOPos, 1))
            .AppendCallback(() =>
            {
                ps26.SetActive(true);
                ps26Particle.Play();
            })
            .OnComplete(() =>
            {
                ps17.SetActive(false);
                ps18.SetActive(false);
                ps19.SetActive(false);
                ps20.SetActive(false);
                ps21.SetActive(false);
                FinishEffect(lastword, wordNum);
            });
    }
}
