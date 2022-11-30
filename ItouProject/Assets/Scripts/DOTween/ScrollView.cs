using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class ScrollView : MonoBehaviour
{
    private bool onOff = false;
    [SerializeField] private TextMeshProUGUI scrollButtontext;
    
    public void Move()
    {
        if (onOff)
        {
            gameObject.transform.DOMoveX(-155, 1);
            scrollButtontext.text = ">";
            onOff = false;
        }
        else
        {
            gameObject.transform.DOMoveX(155, 1);
            scrollButtontext.text = "<";
            onOff = true;
        }
    }
}
