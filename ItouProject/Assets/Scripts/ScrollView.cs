using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScrollView : MonoBehaviour
{
    [SerializeField] private GameObject text;
    [SerializeField] private GameObject textContent;


    public void OnClick()
    {
        GameObject obj = Instantiate(text, transform.position, Quaternion.identity);
        obj.transform.parent = transform;
    }
}
