using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    private List<string> wordList = new List<string>();
    public char lastWord = 'り';
    [SerializeField] private TextMeshProUGUI lastWordUI;

    [SerializeField] private ScrollViews _scrollViews;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Wizard _wizard;
    [SerializeField] private JackO _jackO;

    enum Turn
    {
        WizardTurn,
        JackOTurn
    }

    private Turn turn;

    public void AddWordList(string addWord)
    {
        if (wordList.Contains(addWord))
        {
            Debug.Log("既に言われた言葉です");
        }else if (lastWord != addWord.FirstOrDefault()) {
            Debug.Log("「"+ lastWord + "」から始まっていません");
        }else {
            _scrollViews.AddText(addWord);
            wordList.Add(addWord);
            Debug.Log(wordList.Count);

            lastWord = addWord.LastOrDefault();
            if (lastWord == 'ん')
            {
                Debug.Log("game over");
            }
            lastWordUI.text = "「" + lastWord + "」から始まる";
            _enemy.Response(lastWord);
        }
    }
    
    public void AddWordListEnemy(string addWord)
    {
        lastWord = addWord.LastOrDefault();
        if (wordList.Contains(addWord)) Debug.Log("既に言われた言葉でした");
        else if (lastWord == 'ん') Debug.Log("game over　Enemy");
        
        _scrollViews.AddText(addWord);
        wordList.Add(addWord);
        Debug.Log(wordList.Count);
        
        lastWordUI.text = "「" + lastWord + "」から始まる";
    }

    private void Start()
    {
        turn = Turn.WizardTurn;
        StartCoroutine("WaitSeconds");
    }

    private void Update()
    {
        if (turn == Turn.WizardTurn)
        {
            StartCoroutine("WaitSecondsWizard");
        }
        else
        {
            StartCoroutine("WaitSecondsJackO");
        }
    }

    IEnumerator WaitSeconds()
    {
        yield return new WaitForSeconds(3);
    }
    
    IEnumerator WaitSecondsWizard()
    {
        yield return new WaitForSeconds(3);
        _jackO.HurtJackO(2);
    }
    
    IEnumerator WaitSecondsJackO()
    {
        yield return new WaitForSeconds(3);
        _wizard.HurtWizard(2);
    }
}
