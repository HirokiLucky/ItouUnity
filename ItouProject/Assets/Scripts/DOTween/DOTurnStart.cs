using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class DOTurnStart : MonoBehaviour
{
    [SerializeField] private GameObject _parent;
    [SerializeField] private GameObject black;
    [SerializeField] private Image blackImage;
    [SerializeField] private Image bigImage;
    [SerializeField] private Image smallImage;
    [SerializeField] private Text text;
    private Vector3 _vector1 = new Vector3(1, 1, 1);
    private Vector3 _vector0 = new Vector3(0, 0, 0);
    private Vector3 _vector10 = new Vector3(10, 10, 10);
    private Vector3 _vector360P = new Vector3(0, 0, 180);
    private Vector3 _vector360M = new Vector3(0, 0, -180);

    public void TurnStart(){
        _parent.SetActive(true);
        black.SetActive(true);
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(text.transform.DOScale(_vector1, 0.5f).SetEase(Ease.OutSine))
            .Join(blackImage.DOColor(new Color(0, 0, 0, 0.33f), 0.5f))
            .Join(bigImage.transform.DOScale(_vector1, 0.5f))
            .Join(smallImage.transform.DOScale(_vector1, 0.5f))
            .Join(bigImage.transform.DOLocalRotate(_vector360P, 3f).SetRelative(true))
            .Join(smallImage.transform.DOLocalRotate(_vector360M, 3f).SetRelative(true))
            .Append(text.transform.DOScale(_vector0, 0.5f))
            .Join(bigImage.transform.DOScale(_vector10, 0.5f))
            .Join(smallImage.transform.DOScale(_vector10, 0.5f))
            .Join(blackImage.DOColor(new Color(0, 0, 0, 0), 0.5f))
            .OnComplete(() =>
            {
                _parent.SetActive(false);
                black.SetActive(false);
            });

    }
}
