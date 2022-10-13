using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViews : MonoBehaviour
{
    [SerializeField] private GameObject text;
    [SerializeField] private TextMeshProUGUI textContent;


    public void AddText(string ViewText)
    {
        Debug.Log("ScrollViewに表示");
        GameObject obj = Instantiate(text, transform.position, Quaternion.identity);
        obj.transform.SetParent(transform);
        textContent = obj.GetComponent<TextMeshProUGUI>();
        textContent.text = ViewText;
    }
}
