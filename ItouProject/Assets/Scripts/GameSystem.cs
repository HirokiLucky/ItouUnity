using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
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
    [SerializeField] private Listenner _listenner;
    
    GameObject clickedGameObject;
    [SerializeField] private GameObject magicButton;
    [SerializeField] private GameObject stopButton;

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

    private void Update()
    {
        ClickCard();
    }

    void ClickCard()
    {
        if (Input.GetMouseButtonDown(0)){
 
            clickedGameObject = null;
 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
 
            if (hit2d) {
                clickedGameObject = hit2d.transform.gameObject;
            }

            if (clickedGameObject != null)
            {
                if(clickedGameObject.CompareTag("Card"))
                {
                    Debug.Log(clickedGameObject);
                    magicButton.SetActive(true);
                    stopButton.SetActive(true);
                    _listenner.OnClickSpeechToTextButton();
                }
            }
        }
    }
}
