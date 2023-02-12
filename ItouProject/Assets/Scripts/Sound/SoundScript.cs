using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;

    void Start () {
        audioSource = GetComponent<AudioSource>();
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            //音(sound1)を鳴らす
            audioSource.PlayOneShot(sound1);
        }
    }
}
