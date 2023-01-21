using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;
using Sequence = DG.Tweening.Sequence;

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
    public bool firstAttackVariable;

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
            .Append(cameraObject.transform.DOMove(origin, 3)).SetEase(Ease.InSine)
            .OnComplete(() => Judge());
    }

    public void Judge()
    {
        int angle = 0;
        firstAttackVariable = DecideFirstAttack();
        parent.SetActive(true);
        black.SetActive(true);
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(blackImage.DOColor(new Color(0, 0, 0, 0.33f), 0.5f))
            .Join(parentRect.DOAnchorPosY(0, 0.5f).SetEase(Ease.OutElastic))
            .AppendCallback(() =>
            {
                if (firstAttackVariable) yazirushiParent.DOLocalRotate(new Vector3(0, 0, 3690), 5, RotateMode.FastBeyond360).SetEase(Ease.OutExpo);
                else yazirushiParent.DOLocalRotate(new Vector3(0, 0, 3510), 5, RotateMode.FastBeyond360).SetEase(Ease.OutExpo);
            })
            .AppendInterval(6)
            .Append(parentRect.DOAnchorPosY(300, 0.5f).SetEase(Ease.InOutQuint))
            .OnComplete(() =>
            {
                parent.SetActive(false);
            });
    }

    bool DecideFirstAttack()
    {
        return Random.Range(0, 2) == 0;
    }
}
