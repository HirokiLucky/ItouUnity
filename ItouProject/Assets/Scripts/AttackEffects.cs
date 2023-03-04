using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class AttackEffects : MonoBehaviour
{
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

    private Vector2 wizardPos = new Vector2(-6, -3.1f);
    private Vector2 JackOPos = new Vector2(6, -3.2f);
    private Vector3 wizardCamera = new Vector3(-6, -2, -1);
    private Vector3 jackOCamera = new Vector3(6, -2, -1);
    private Vector3 origin = new Vector3(0, -5, -1);

    private float hitStopTimer = 0f;

    [SerializeField] private GameObject _cameraObject;
    private Camera _camera;

    [SerializeField] private SoundScript _soundScript;

    [SerializeField] private GameObject damageEffect;

    private void Start()
    {
        _camera = _cameraObject.GetComponent<Camera>();
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
    
    // ヒットストップの管理
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

    // プレイヤー側のエフェクト中止    
    void FinishEffect(char lastword, int wordCount)
    {
        _jackO.HurtJackO(wordCount);
        if(_jackO.hpJackO > 0) _gameSystem.EnemyTurn(lastword, wordCount);
    }
    
    // エネミー側のエフェクト中止    
    void FinishEffectEnemy(int wordCount)
    {
        _wizard.HurtWizard(wordCount);
        if(_wizard.hpWizard > 0) _gameSystem.YourTurn();
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
        EffectmanagerEnemy(wordCount);
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
    
    void EffectmanagerEnemy(int wordNum)
    {
        switch (wordNum)
        {
            case 2:
                Level2Enemy(wordNum);
                break;
            case 3:
                Level3Enemy(wordNum);
                break;
            case 4:
                Level4Enemy(wordNum);
                break;
            case 5:
                Level5Enemy(wordNum);
                break;
            case 6:
                Level6Enemy(wordNum);
                break;
            case 7:
                Level7Enemy(wordNum);
                break;
            case 8:
                Level8Enemy(wordNum);
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

    // プレイヤー側アタックエフェクト
    // level2
    public void Level2(char lastword,int wordNum)
    {
        WizardMagic();
        ps1.transform.position = JackOPos;
        ps2.transform.position = JackOPos;
        damageEffect.transform.position = JackOPos;
        Sequence sequence = DOTween.Sequence();
        sequence
            .AppendInterval(0.1f)
            .AppendCallback(() =>
            {
                _cameraObject.transform.DOMove(jackOCamera, 0.5f);
                _camera.DOOrthoSize(3, 0.5f);
            })
            .AppendInterval(0.5f)
            .AppendCallback(() =>
            {
                _soundScript.Level2SE();
                ps1.SetActive(true);
                ps2.SetActive(true);
                damageEffect.SetActive(true);
                ps1Particle.Play();
                ps2Particle.Play();
            })
            .Append(ps2.transform.DOMove(new Vector3(2,2), 1).SetEase(Ease.OutExpo)).SetRelative(true)
            .Join(damageEffect.transform.DOMove(new Vector3(-2,1), 1).SetEase(Ease.OutExpo)).SetRelative(true)
            .OnComplete(() =>
            {
                damageEffect.SetActive(false);
                _cameraObject.transform.DOMove(origin, 1);
                _camera.DOOrthoSize(5, 1f);
                FinishEffect(lastword, wordNum);
            });
    }
    
    // level3
    public void Level3(char lastword,int wordNum)
    {
        WizardMagic();
        ps3.transform.position = wizardPos + new Vector2(2, 1);
        ps4.transform.position = JackOPos + new Vector2(0, 3);
        damageEffect.transform.position = JackOPos;
        ps3.SetActive(true);
        ps3Particle.Play();
        _soundScript.Level3FireSE();
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(ps3.transform.DOMove(JackOPos, 3).SetEase(Ease.InExpo))
            .AppendCallback(() =>
            {
                _cameraObject.transform.DOMove(jackOCamera, 0.1f);
                _camera.DOOrthoSize(3, 0.1f);
            })
            .AppendInterval(0.1f)
            .AppendCallback(() =>
            {
                ps4.SetActive(true);
                damageEffect.SetActive(true);
                ps4Particle.Play();
                _soundScript.Level3SlashSE();
                hitStopTimer = 0.01f;
            })
            .Insert(0, damageEffect.transform.DOMove(new Vector3(-2,1), 1).SetEase(Ease.OutExpo).SetRelative(true))
            .AppendCallback(() =>
            {
                _cameraObject.transform.DOMove(origin, 0.5f);
                _camera.DOOrthoSize(5, 0.5f);
            })
            .Append(ps3.transform.DOMoveX(10, 1))
            .OnComplete(() =>
            {
                damageEffect.SetActive(false);
                ps3.SetActive(false);
                FinishEffect(lastword, wordNum);
            });
    }
    
    // level4
    public void Level4(char lastword,int wordNum)
    {
        WizardMagic();
        ps5.transform.position = wizardPos + new Vector2(2, 2);
        ps6.transform.position = JackOPos;
        damageEffect.transform.position = JackOPos;
        ps5.SetActive(true);
        ps5Particle.Play();
        _soundScript.Level4thunder1SE();
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(ps5.transform.DOMove(JackOPos, 4))
            .AppendCallback(() =>
            {
                ps6.SetActive(true);
                damageEffect.SetActive(true);
                ps6Particle.Play();
                _soundScript.Level4thunder2SE();
            })
            .Insert(0, damageEffect.transform.DOMove(new Vector3(-2,1), 1).SetEase(Ease.OutExpo).SetRelative(true))
            .AppendCallback(() =>
            {
                _cameraObject.transform.DOMove(jackOCamera, 0.1f);
                _camera.DOOrthoSize(3, 0.1f);
            })
            .AppendInterval(0.3f)
            .AppendCallback(() => hitStopTimer = 0.01f)
            .AppendInterval(0.5f)
            .AppendCallback(() =>
            {
                _cameraObject.transform.DOMove(origin, 0.5f);
                _camera.DOOrthoSize(5, 0.5f);
            })
            .OnComplete(() =>
            {
                damageEffect.SetActive(false);
                ps5.SetActive(false);
                FinishEffect(lastword, wordNum);
                
                // 状態異常
                _jackO.paralysis = true;
                _jackO.paralysisUI.SetActive(true);
                
            });;
    }
    
    // level5
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
        _soundScript.Level5FaaSE();
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
                _soundScript.Level5HealSE();
            })
            .Append(ps9.transform.DOMoveY(2, 2).SetEase(Ease.OutSine)).SetRelative(true)
            .OnStart(() =>
            {
                _cameraObject.transform.DOMove(wizardCamera, 1f);
                _camera.DOOrthoSize(4, 1f);
            })
            .OnComplete(() =>
            {
                _cameraObject.transform.DOMove(origin, 0.5f);
                _camera.DOOrthoSize(5, 0.5f);
                FinishEffect(lastword, wordNum);
            });
    }
    
    // level6
    public void Level6(char lastword,int wordNum)
    {
        WizardMagic();
        ps10.transform.position = wizardPos + new Vector2(2,2);
        ps11.transform.position = wizardPos + new Vector2(4,2);
        ps12.transform.position = JackOPos;
        damageEffect.transform.position = JackOPos;
        ps10.SetActive(true);
        ps10Particle.Play();
        ps11.SetActive(true);
        ps11Particle.Play();
        _soundScript.Level6MagicSE();
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(ps11.transform.DOScale(new Vector3(2,2), 3))
            .Append(ps11.transform.DOMove(JackOPos, 3))
            .AppendCallback(() =>
            {
                ps11.SetActive(false);
                ps12.SetActive(true);
                ps12Particle.Play();
                _cameraObject.transform.DOMove(jackOCamera, 0.9f);
                _camera.DOOrthoSize(3, 0.9f);
            })
            .AppendInterval(1f)
            .AppendCallback(() =>
            {
                damageEffect.SetActive(true);
                hitStopTimer = 0.015f;
                _soundScript.Level6GlassSE();
                ps10.SetActive(false);
            })
            .Join(damageEffect.transform.DOMove(new Vector3(-2,1), 0.5f).SetEase(Ease.OutExpo).SetRelative(true))
            .OnComplete(() =>
            {
                damageEffect.SetActive(false);
                _cameraObject.transform.DOMove(origin, 0.5f);
                _camera.DOOrthoSize(5, 0.5f);
                FinishEffect(lastword, wordNum);
                
                // 状態異常
                if (_jackO.spell == -1)
                {
                    _jackO.spell = 3;
                    _jackO.spellUI.SetActive(true);
                }
            });
    }
    
    // level7
    public void Level7(char lastword,int wordNum)
    {
        WizardMagic();
        ps13.transform.position = wizardPos;
        ps14.transform.position = JackOPos + new Vector2(0,2);
        ps15.transform.position = JackOPos + new Vector2(0,2);
        ps16.transform.position = new Vector3(6,-4,10);
        damageEffect.transform.position = JackOPos;
        ps13.SetActive(true);
        ps13Particle.Play();
        _soundScript.Level7HolySE();
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(ps13.transform.DOMove(JackOPos + new Vector2(0,2), 5))
            .AppendCallback(() =>
            {
                _cameraObject.transform.DOMove(jackOCamera, 0.5f);
                _camera.DOOrthoSize(3, 0.5f);
                ps14.SetActive(true);
                ps14Particle.Play();
                ps15.SetActive(true);
                ps15Particle.Play();
                ps13.SetActive(false);
                _soundScript.Level7LMGSE();
            })
            .AppendInterval(1)
            .AppendCallback(() =>
            {
                ps16.SetActive(true);
                damageEffect.SetActive(true);
                ps16Particle.Play();
            })
            .Append(damageEffect.transform.DOMove(new Vector3(-2,1), 1).SetEase(Ease.OutExpo).SetRelative(true))
            .AppendInterval(1)
            .OnComplete(() =>
            {
                damageEffect.SetActive(false);
                _cameraObject.transform.DOMove(origin, 0.5f);
                _camera.DOOrthoSize(5, 0.5f);
                ps15.SetActive(false);
                ps16.SetActive(false);
                
                // 状態異常
                if (_jackO.fire == 0)
                {
                    _jackO.fire = 3;
                    _jackO.fireUI.SetActive(true);
                }

                FinishEffect(lastword, wordNum);
            });
    }
    
    // Level8
    public void Level8(char lastword,int wordNum)
    {
        WizardMagic();
        Vector2 grond = new Vector2(6, -4);
        ps17.transform.position = wizardPos;
        ps18.transform.position = wizardPos;
        ps19.transform.position = wizardPos;
        ps20.transform.position = wizardPos;
        ps21.transform.position = wizardPos;
        damageEffect.transform.position = JackOPos;
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
        _soundScript.Level8MagicSE();
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(ps17.transform.DOMove( JackOPos + new Vector2(0,4), 2))
            .Join(ps18.transform.DOMove( JackOPos + new Vector2(4,0), 2))
            .Join(ps19.transform.DOMove( JackOPos + new Vector2(-4,0), 2))
            .Join(ps20.transform.DOMove( JackOPos + new Vector2(2,2), 2))
            .Join(ps21.transform.DOMove( JackOPos + new Vector2(-2,2), 2))
            .AppendCallback(() =>
            {
                _cameraObject.transform.DOMove(jackOCamera, 0.5f);
                _camera.DOOrthoSize(4, 0.5f);
            })
            .Append(ps17.transform.DOMove( JackOPos, 1))
            .AppendCallback(() =>
            {
                ps22.SetActive(true);
                ps22Particle.Play();
                _soundScript.Level8Ex1SE();
            })
            .Append(ps18.transform.DOMove( JackOPos, 1))
            .AppendCallback(() =>
            {
                ps23.SetActive(true);
                ps23Particle.Play();
                _soundScript.Level8Ex1SE();
            })
            .Append(ps19.transform.DOMove( JackOPos, 1))
            .AppendCallback(() =>
            {
                ps24.SetActive(true);
                ps24Particle.Play();
                _soundScript.Level8Ex1SE();
            })
            .Append(ps20.transform.DOMove( JackOPos, 1))
            .AppendCallback(() =>
            {
                ps25.SetActive(true);
                ps25Particle.Play();
                _soundScript.Level8Ex1SE();
            })
            .Append(ps21.transform.DOMove( JackOPos, 1))
            .AppendCallback(() =>
            {
                ps26.SetActive(true);
                damageEffect.SetActive(true);
                ps26Particle.Play();
                _soundScript.Level8Ex2SE();
            })
            .Join(damageEffect.transform.DOMove(new Vector3(-2,1), 1).SetEase(Ease.OutExpo).SetRelative(true))
            .OnComplete(() =>
            {
                damageEffect.SetActive(false);
                _cameraObject.transform.DOMove(origin, 0.5f);
                _camera.DOOrthoSize(5, 0.5f);
                ps17.SetActive(false);
                ps18.SetActive(false);
                ps19.SetActive(false);
                ps20.SetActive(false);
                ps21.SetActive(false);
                
                // 状態異常
                _jackO.paralysis = true;
                _jackO.paralysisUI.SetActive(true);
                if (_jackO.fire == 0)
                {
                    _jackO.fire = 3;
                    _jackO.fireUI.SetActive(true);
                }
                
                FinishEffect(lastword, wordNum);
            });
    }
    
    // 敵側のアタックエフェクト
    // level2
    public void Level2Enemy(int wordNum)
    {
        _jackO.AttackJackO();
        ps1.transform.position = wizardPos;
        ps2.transform.position = wizardPos;
        damageEffect.transform.position = wizardPos;
        Sequence sequence = DOTween.Sequence();
        sequence
            .AppendInterval(0.1f)
            .AppendCallback(() =>
            {
                _cameraObject.transform.DOMove(wizardCamera, 0.5f);
                _camera.DOOrthoSize(3, 0.5f);
            })
            .AppendInterval(0.5f)
            .AppendCallback(() =>
            {
                _soundScript.Level2SE();
                ps1.SetActive(true);
                ps2.SetActive(true);
                damageEffect.SetActive(true);
                ps1Particle.Play();
                ps2Particle.Play();
            })
            .Append(ps2.transform.DOMove(new Vector3(2,2), 1).SetEase(Ease.OutExpo)).SetRelative(true)
            .Join(damageEffect.transform.DOMove(new Vector3(2,1), 1).SetEase(Ease.OutExpo)).SetRelative(true)
            .OnComplete(() =>
            {
                damageEffect.SetActive(false);
                _cameraObject.transform.DOMove(origin, 1);
                _camera.DOOrthoSize(5, 1f);
                FinishEffectEnemy(wordNum);
            });
    }
    
    // level3
    public void Level3Enemy(int wordNum)
    {
        _jackO.AttackJackO();
        ps3.transform.position = JackOPos + new Vector2(-2, 1);
        ps4.transform.position = wizardPos + new Vector2(0, 3);
        damageEffect.transform.position = wizardPos;
        ps3.SetActive(true);
        ps3Particle.Play();
        _soundScript.Level3FireSE();
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(ps3.transform.DOMove(wizardPos, 3).SetEase(Ease.InExpo))
            .AppendCallback(() =>
            {
                _cameraObject.transform.DOMove(wizardCamera, 0.1f);
                _camera.DOOrthoSize(3, 0.1f);
            })
            .AppendInterval(0.1f)
            .AppendCallback(() =>
            {
                ps4.SetActive(true);
                damageEffect.SetActive(true);
                ps4Particle.Play();
                _soundScript.Level3SlashSE();
                hitStopTimer = 0.01f;
            })
            .Insert(0, damageEffect.transform.DOMove(new Vector3(2,1), 1).SetEase(Ease.OutExpo).SetRelative(true))
            .AppendCallback(() =>
            {
                _cameraObject.transform.DOMove(origin, 0.5f);
                _camera.DOOrthoSize(5, 0.5f);
            })
            .Append(ps3.transform.DOMoveX(-10, 1))
            .OnComplete(() =>
            {
                damageEffect.SetActive(false);
                ps3.SetActive(false);
                FinishEffectEnemy(wordNum);
            });
    }
    
    // level4
    public void Level4Enemy(int wordNum)
    {
        _jackO.AttackJackO();
        ps5.transform.position = JackOPos + new Vector2(-2, 2);
        ps6.transform.position = wizardPos;
        damageEffect.transform.position = wizardPos;
        ps5.SetActive(true);
        ps5Particle.Play();
        _soundScript.Level4thunder1SE();
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(ps5.transform.DOMove(wizardPos, 4))
            .AppendCallback(() =>
            {
                ps6.SetActive(true);
                damageEffect.SetActive(true);
                ps6Particle.Play();
                _soundScript.Level4thunder2SE();
            })
            .Insert(0, damageEffect.transform.DOMove(new Vector3(2,1), 1).SetEase(Ease.OutExpo).SetRelative(true))
            .AppendCallback(() =>
            {
                _cameraObject.transform.DOMove(wizardCamera, 0.1f);
                _camera.DOOrthoSize(3, 0.1f);
            })
            .AppendInterval(0.3f)
            .AppendCallback(() => hitStopTimer = 0.01f)
            .AppendInterval(0.5f)
            .AppendCallback(() =>
            {
                _cameraObject.transform.DOMove(origin, 0.5f);
                _camera.DOOrthoSize(5, 0.5f);
            })
            .OnComplete(() =>
            {
                damageEffect.SetActive(false);
                ps5.SetActive(false);
                FinishEffectEnemy(wordNum);
                
                // 状態異常
                _wizard.paralysis = true;
                _wizard.paralysisUI.SetActive(true);
            });;
    }
    
    // level5
    public void Level5Enemy(int wordNum)
    {
        _jackO.AttackJackO();
        ps7.transform.position = JackOPos;
        ps8.transform.position = JackOPos;
        ps9.transform.position = JackOPos;

        ps7.SetActive(true);
        ps7Particle.Play();
        ps8.SetActive(true);
        ps8Particle.Play();
        _soundScript.Level5FaaSE();
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
                _soundScript.Level5HealSE();
            })
            .Append(ps9.transform.DOMoveY(2, 2).SetEase(Ease.OutSine)).SetRelative(true)
            .OnStart(() =>
            {
                _cameraObject.transform.DOMove(jackOCamera, 1f);
                _camera.DOOrthoSize(4, 1f);
            })
            .OnComplete(() =>
            {
                _cameraObject.transform.DOMove(origin, 0.5f);
                _camera.DOOrthoSize(5, 0.5f);
                FinishEffectEnemy(wordNum);
            });
    }
    
    // level6
    public void Level6Enemy(int wordNum)
    {
        _jackO.AttackJackO();
        ps10.transform.position = JackOPos + new Vector2(-2,2);
        ps11.transform.position = JackOPos + new Vector2(-4,2);
        ps12.transform.position = wizardPos;
        damageEffect.transform.position = wizardPos;
        ps10.SetActive(true);
        ps10Particle.Play();
        ps11.SetActive(true);
        ps11Particle.Play();
        _soundScript.Level6MagicSE();
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(ps11.transform.DOScale(new Vector3(2,2), 3))
            .Append(ps11.transform.DOMove(wizardPos, 3))
            .AppendCallback(() =>
            {
                
                ps11.SetActive(false);
                ps12.SetActive(true);
                ps12Particle.Play();
                _cameraObject.transform.DOMove(wizardCamera, 0.9f);
                _camera.DOOrthoSize(3, 0.9f);
            })
            .AppendInterval(1f)
            .AppendCallback(() =>
            {
                damageEffect.SetActive(true);
                hitStopTimer = 0.015f;
                _soundScript.Level6GlassSE();
                ps10.SetActive(false);
            })
            .Join(damageEffect.transform.DOMove(new Vector3(2,1), 0.5f).SetEase(Ease.OutExpo).SetRelative(true))
            .OnComplete(() =>
            {
                damageEffect.SetActive(false);
                _cameraObject.transform.DOMove(origin, 0.5f);
                _camera.DOOrthoSize(5, 0.5f);
                FinishEffectEnemy(wordNum);
                
                // 状態異常
                if (_wizard.spell == -1)
                {
                    _wizard.spell = 3;
                    _wizard.spellUI.SetActive(true);
                }
            });
    }
    
    // level7
    public void Level7Enemy(int wordNum)
    {
        _jackO.AttackJackO();
        ps13.transform.position = JackOPos;
        ps14.transform.position = wizardPos + new Vector2(0,2);
        ps15.transform.position = wizardPos + new Vector2(0,2);
        ps16.transform.position = new Vector3(-6,-4,10);
        damageEffect.transform.position = wizardPos;
        ps13.SetActive(true);
        ps13Particle.Play();
        _soundScript.Level7HolySE();
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(ps13.transform.DOMove(wizardPos + new Vector2(0,2), 5))
            .AppendCallback(() =>
            {
                _cameraObject.transform.DOMove(wizardCamera, 0.5f);
                _camera.DOOrthoSize(3, 0.5f);
                ps14.SetActive(true);
                ps14Particle.Play();
                ps15.SetActive(true);
                ps15Particle.Play();
                ps13.SetActive(false);
                _soundScript.Level7LMGSE();
            })
            .AppendInterval(1)
            .AppendCallback(() =>
            {
                ps16.SetActive(true);
                damageEffect.SetActive(true);
                ps16Particle.Play();
            })
            .Append(damageEffect.transform.DOMove(new Vector3(2,1), 1).SetEase(Ease.OutExpo).SetRelative(true))
            .AppendInterval(1)
            .OnComplete(() =>
            {
                damageEffect.SetActive(false);
                _cameraObject.transform.DOMove(origin, 0.5f);
                _camera.DOOrthoSize(5, 0.5f);
                ps15.SetActive(false);
                ps16.SetActive(false);

                // 状態異常
                if (_wizard.fire == 0)
                {
                    _wizard.fire = 3;
                    _wizard.fireUI.SetActive(true);
                }
                
                FinishEffectEnemy(wordNum);
            });
    }
    
    // Level8
    public void Level8Enemy(int wordNum)
    {
        _jackO.AttackJackO();
        Vector2 grond = new Vector2(-6, -4);
        ps17.transform.position = JackOPos;
        ps18.transform.position = JackOPos;
        ps19.transform.position = JackOPos;
        ps20.transform.position = JackOPos;
        ps21.transform.position = JackOPos;
        damageEffect.transform.position = wizardPos;
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
        _soundScript.Level8MagicSE();
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(ps17.transform.DOMove( wizardPos + new Vector2(0,4), 2))
            .Join(ps18.transform.DOMove( wizardPos + new Vector2(4,0), 2))
            .Join(ps19.transform.DOMove( wizardPos + new Vector2(-4,0), 2))
            .Join(ps20.transform.DOMove( wizardPos + new Vector2(2,2), 2))
            .Join(ps21.transform.DOMove( wizardPos + new Vector2(-2,2), 2))
            .AppendCallback(() =>
            {
                _cameraObject.transform.DOMove(wizardCamera, 0.5f);
                _camera.DOOrthoSize(4, 0.5f);
            })
            .Append(ps17.transform.DOMove( wizardPos, 1))
            .AppendCallback(() =>
            {
                ps22.SetActive(true);
                ps22Particle.Play();
                _soundScript.Level8Ex1SE();
            })
            .Append(ps18.transform.DOMove( wizardPos, 1))
            .AppendCallback(() =>
            {
                ps23.SetActive(true);
                ps23Particle.Play();
                _soundScript.Level8Ex1SE();
            })
            .Append(ps19.transform.DOMove( wizardPos, 1))
            .AppendCallback(() =>
            {
                ps24.SetActive(true);
                ps24Particle.Play();
                _soundScript.Level8Ex1SE();
            })
            .Append(ps20.transform.DOMove( wizardPos, 1))
            .AppendCallback(() =>
            {
                ps25.SetActive(true);
                ps25Particle.Play();
                _soundScript.Level8Ex1SE();
            })
            .Append(ps21.transform.DOMove( wizardPos, 1))
            .AppendCallback(() =>
            {
                ps26.SetActive(true);
                damageEffect.SetActive(true);
                ps26Particle.Play();
                _soundScript.Level8Ex2SE();
            })
            .Join(damageEffect.transform.DOMove(new Vector3(2,1), 1).SetEase(Ease.OutExpo).SetRelative(true))
            .OnComplete(() =>
            {
                damageEffect.SetActive(false);
                _cameraObject.transform.DOMove(origin, 0.5f);
                _camera.DOOrthoSize(5, 0.5f);
                ps17.SetActive(false);
                ps18.SetActive(false);
                ps19.SetActive(false);
                ps20.SetActive(false);
                ps21.SetActive(false);
                
                // 状態異常
                _wizard.paralysis = true;
                _wizard.paralysisUI.SetActive(true);
                if (_wizard.fire == 0)
                {
                    _wizard.fire = 3;
                    _wizard.fireUI.SetActive(true);
                }
                
                FinishEffectEnemy(wordNum);
            });
    }
}
