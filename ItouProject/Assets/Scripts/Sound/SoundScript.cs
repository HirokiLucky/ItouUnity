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
    public AudioClip sound6;
    public AudioClip sound7;
    public AudioClip sound8;
    public AudioClip sound9;
    public AudioClip sound10;
    AudioSource audioSource;

    void Start () {
        audioSource = GetComponent<AudioSource>();
    }
    
    // シーン開始のコウモリエフェクト用
    public void BatFly()
    {
        audioSource.PlayOneShot(bat);
    }
    
    // 先行後攻のUI用
    public void DropJudge()
    {
        audioSource.PlayOneShot(dropJudge);
    }
    
    public void Roll()
    {
        audioSource.PlayOneShot(roll);
    }
    
    public void FinishRoll()
    {
        audioSource.PlayOneShot(finishRoll);
    }
    
    // ターン開始UI用
    public void StartTurn()
    {
        audioSource.PlayOneShot(slowMotion);
    }
    
    // 認識文字用
    
}
