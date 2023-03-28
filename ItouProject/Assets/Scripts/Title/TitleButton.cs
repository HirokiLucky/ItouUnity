using System;
using System.Collections;
using System.Collections.Generic;
using ExitGames.Client.Photon.StructWrapping;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButton : MonoBehaviour
{
    [SerializeField] private GameObject howToPlay;

    GameObject[] howToPlayScreen;
    private int page = 0;
    [SerializeField] private GameObject screen1;
    [SerializeField] private GameObject screen2;
    [SerializeField] private GameObject screen3;
    [SerializeField] private GameObject screen4;
    [SerializeField] private GameObject screen5;


    private void Start()
    {
        howToPlayScreen = new GameObject[] { screen1, screen2, screen3, screen4, screen5};
    }

    public void OnClickSingle()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OnClickMulti()
    {
        Debug.Log("未実装");
    }

    // HowToPlay のボタン
    public void OnClickHowToPlay()
    {
        page = 0;
        howToPlay.SetActive(true);
        howToPlayScreen[page].SetActive(true);
    }
    
    public void OnClickBackScreenButton()
    {
        howToPlayScreen[page].SetActive(false);
        howToPlay.SetActive(false);
    }
    
    public void OnClickNextButton()
    {
        howToPlayScreen[page].SetActive(false);
        if (page != 4) page++;
        else page = 0;
        howToPlayScreen[page].SetActive(true);
    }
    
    public void OnClickBackButton()
    {
        howToPlayScreen[page].SetActive(false);
        if (page != 0) page--;
        else page = 4;
        howToPlayScreen[page].SetActive(true);
    }
}
