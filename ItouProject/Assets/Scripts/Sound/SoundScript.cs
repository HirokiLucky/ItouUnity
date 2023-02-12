using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public AudioClip bat;
    public AudioClip dropJudge;
    public AudioClip roll;
    public AudioClip finishRoll;
    public AudioClip slowMotion;
    public AudioClip returnTextSE;
    public AudioClip hirateuti;
    public AudioClip fire;
    public AudioClip SlashSword;
    public AudioClip thunderStart;
    public AudioClip thunderAttack;
    public AudioClip heal;
    public AudioClip faa;
    public AudioClip a;
    public AudioClip sound10;
    AudioSource audioSource;

    void Start () {
        audioSource = GetComponent<AudioSource>();
    }
    
    // シーン開始のコウモリエフェクト用
    public void BatFlySE()
    {
        audioSource.PlayOneShot(bat);
    }
    
    // 先行後攻のUI用
    public void DropJudgeSE()
    {
        audioSource.PlayOneShot(dropJudge);
    }
    
    public void RollSE()
    {
        audioSource.PlayOneShot(roll);
    }
    
    public void FinishRollSE()
    {
        audioSource.PlayOneShot(finishRoll);
    }
    
    // ターン開始UI用
    public void StartTurnSE()
    {
        audioSource.PlayOneShot(slowMotion);
    }
    
    // 認識文字用
    public void ReturnTextUISE()
    {
        audioSource.PlayOneShot(returnTextSE);
    }
    
    // 攻撃用
    // Level2(はたく)
    public void Level2SE()
    {
        audioSource.PlayOneShot(hirateuti);
    }
    
    // Level3(火の剣)
    public void Level3FireSE()
    {
        audioSource.PlayOneShot(fire);
    }
    
    public void Level3SlashSE()
    {
        audioSource.PlayOneShot(SlashSword);
    }
    
    // Level4(電気)
    public void Level4thunder1SE()
    {
        audioSource.PlayOneShot(thunderStart);
    }
    
    public void Level4thunder2SE()
    {
        audioSource.PlayOneShot(thunderAttack);
    }
    
    // Level5(回復)
    public void Level5HealSE()
    {
        audioSource.PlayOneShot(heal);
    }
    
    public void Level5FaaSE()
    {
        audioSource.PlayOneShot(faa);
    }

    // Level6(ハート)
    // Level7(上から落ちてくる)
    // Level8(爆弾)
}
