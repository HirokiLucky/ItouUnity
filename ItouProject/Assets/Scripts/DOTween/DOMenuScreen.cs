using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class DOMenuScreen : MonoBehaviour
{
    private RectTransform rect;
    private bool spread;

    private void Start()
    {
        rect = gameObject.GetComponent<RectTransform>();
    }

    public void OnClickMenuButton()
    {
        if (spread)
        {
            spread = false;
            Sequence sequence = DOTween.Sequence();
            sequence
                .Append(rect.DOAnchorPos(new Vector2(350, 150), 0.5f)).SetEase(Ease.InSine)
                .Join(rect.DOScale(new Vector3(0, 0, 0), 0.5f));
        }
        else
        {
            spread = true;
            Sequence sequence = DOTween.Sequence();
            sequence
                .Append(rect.DOAnchorPos(new Vector2(0, 0), 0.5f)).SetEase(Ease.OutSine)
                .Join(rect.DOScale(new Vector3(1, 1, 1), 0.5f));
        }
    }
}
