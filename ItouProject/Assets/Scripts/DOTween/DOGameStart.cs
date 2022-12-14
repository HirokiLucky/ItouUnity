using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class DOGameStart : MonoBehaviour
{
    [SerializeField] private GameObject cameraObject;
    private Camera _camera;

    [SerializeField] private GameObject bat;
    private ParticleSystem batPS;

    private Vector3 origin = new Vector3(0, -5, -1);
    private Vector3 start = new Vector3(0, 3.2f, -1);
    
    void Start()
    {
        _camera = cameraObject.GetComponent<Camera>();
        batPS = bat.GetComponent<ParticleSystem>();
    }


    public void GameStart()
    {
        cameraObject.transform.position = start;
        bat.SetActive(true);
        batPS.Play();
        Sequence sequence = DOTween.Sequence();
        sequence
            .AppendInterval(1f)
            .Append(cameraObject.transform.DOMove(origin, 3)).SetEase(Ease.InSine);
    }
}
