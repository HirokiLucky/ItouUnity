using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class DOGameStart : MonoBehaviour
{
    [SerializeField] private GameObject cameraObject;
    private Camera _camera;

    [SerializeField] private GameObject bat;
    [SerializeField] private ParticleSystem batPS;

    [SerializeField] private GameObject parent;
    private RectTransform parentRect;
    [SerializeField] private Text firstAttack;
    [SerializeField] private Text secondAttack;
    [SerializeField] private RectTransform yazirushiParent;
    [SerializeField] private GameObject black;
    private Image blackImage;

    private Vector3 origin = new Vector3(0, -5, -1);
    private Vector3 start = new Vector3(0, 3.2f, -1);
    
    void Start()
    {
        _camera = cameraObject.GetComponent<Camera>();
        blackImage = black.GetComponent<Image>();
        parentRect = parent.GetComponent<RectTransform>();
    }


    // カメラワーク
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

    public void Judge()
    {
        parent.SetActive(true);
        black.SetActive(true);
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(blackImage.DOColor(new Color(0, 0, 0, 0.33f), 0.5f))
            .Join(parentRect.DOAnchorPosY(0, 0.5f).SetEase(Ease.OutElastic))
            .Append(yazirushiParent.DOLocalRotate(new Vector3(0,0,3600), 5,  RotateMode.FastBeyond360).SetEase(Ease.OutExpo));
    }
}
