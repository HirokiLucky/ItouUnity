using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class ScrollView : MonoBehaviour
{
    private bool onOff = false;
    private RectTransform rect;
    [SerializeField] private TextMeshProUGUI scrollButtontext;

    private void Start()
    {
        rect = gameObject.GetComponent<RectTransform>();
    }

    public void Move()
    {
        if (onOff)
        {
            rect.DOAnchorPosX(-150, 1);
            scrollButtontext.text = ">";
            onOff = false;
        }
        else
        {
            rect.DOAnchorPosX(155, 1);
            scrollButtontext.text = "<";
            onOff = true;
        }
    }
}
