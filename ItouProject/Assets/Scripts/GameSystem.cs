using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameSystem : MonoBehaviour
{
    private List<string> wordList = new List<string>();
    public char lastWord = 'り';
    [SerializeField] private TextMeshProUGUI lastWordUI;
    [SerializeField] private RectTransform yourTurn;
    [SerializeField] private RectTransform enemyTurn;
    [SerializeField] private RectTransform returnText;

    [SerializeField] private ScrollViews _scrollViews;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Wizard _wizard;
    [SerializeField] private JackO _jackO;
    [SerializeField] private Listenner _listenner;
    [SerializeField] private DOTurnStart _doTurnStart;
    [SerializeField] private DOTurnStart _doTurnStartEnemy;
    [SerializeField] private DOGameStart _doGameStart;
    
    GameObject clickedGameObject;
    [NonSerialized]public GameObject clickedGameObject_save;
    [SerializeField] private GameObject magicButton;
    [SerializeField] private GameObject stopButton;
    [SerializeField] private GameObject magicBook;
    [SerializeField] private GameObject clearImage;
    [SerializeField] private GameObject failImage;
    
    //[SerializeField] private GameObject card1;
    [SerializeField] private GameObject card2;
    [SerializeField] private GameObject card3;
    [SerializeField] private GameObject card4;
    [SerializeField] private GameObject card5;
    [SerializeField] private GameObject card6;
    [SerializeField] private GameObject card7;
    [SerializeField] private GameObject card8;
    
    private GameObject selectCard1;
    private GameObject selectCard2;
    private GameObject selectCard3;
    private GameObject[] cards;
    private Vector2 cardSporn = new Vector2(7.6f, -7.25f);

    

    private void Start()
    {
        cards = new[] { card2, card3, card4, card5, card6, card7, card8};
        _doGameStart.GameStart();
        Invoke("YourTurn", 5f);
    }

    private void Update()
    {
        ClickCard();
    }
    
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
    
    // 1番目
    void WizardTurn()
    {
        Sequence sequence = DOTween.Sequence();
        RandomCard();
        sequence
            .Append(selectCard1.transform.DOMoveX(-14f, 1)).SetRelative(true)
            .Join(selectCard2.transform.DOMoveX(-9f, 1).SetRelative(true))
            .Join(selectCard3.transform.DOMoveX(-4f, 1)).SetRelative(true);
    }

    void RandomCard()
    {
        int num1 = Random.Range(0, cards.Length);
        int num2 = Random.Range(0, cards.Length);
        int num3 = Random.Range(0, cards.Length);
        selectCard1 = Instantiate(cards[num1], cardSporn, Quaternion.identity);
        selectCard2 = Instantiate(cards[num2], cardSporn, Quaternion.identity);
        selectCard3 = Instantiate(cards[num3], cardSporn, Quaternion.identity);
    }

    
    // 2番目
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
                    string talotNum = clickedGameObject.name;
                    _listenner.wordCount = Convert.ToInt32(talotNum.Substring(5, 1));
                    Debug.Log(clickedGameObject);
                    magicButton.SetActive(true);
                    stopButton.SetActive(true);
                    SelectCard();
                }
            }
        }
    }

    void SelectCard()
    {
        if (clickedGameObject == selectCard1)
        {
            Sequence _sequence = DOTween.Sequence();
            _sequence.Append(clickedGameObject.transform.DOMoveX(-6,1));
            Destroy(selectCard2);
            Destroy(selectCard3);
            clickedGameObject_save = clickedGameObject;
        }
        else if (clickedGameObject == selectCard2)
        {
            Sequence _sequence = DOTween.Sequence();
            _sequence.Append(clickedGameObject.transform.DOMoveX(-6,1));
            Destroy(selectCard1);
            Destroy(selectCard3);
            clickedGameObject_save = clickedGameObject;
        }
        else if (clickedGameObject == selectCard3)
        {
            Sequence _sequence = DOTween.Sequence();
            _sequence.Append(clickedGameObject.transform.DOMoveX(-6,1));
            Destroy(selectCard1);
            Destroy(selectCard2);
            clickedGameObject_save = clickedGameObject;
        }
    }

    public void YourTurn()
    {
        _doTurnStart.TurnStart();
        Invoke("WizardTurn", 5f);
    }
    
    public void ReturnText()
    {
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(returnText.DOAnchorPosX(0, 0.5f))
            .AppendInterval(1)
            .Append(returnText.DOAnchorPosX(-550, 0.5f))
            .Append(returnText.DOAnchorPosX(550, 0));
    }
    
    public void EnemyTurn()
    {
        _doTurnStartEnemy.TurnStart();
    }

    public void GameOver()
    {
        magicBook.SetActive(true);
        failImage.SetActive(true);
        Debug.Log("You Lose ...");
    }

    public void GameClear()
    {
        magicBook.SetActive(true);
        clearImage.SetActive(true);
    }
}
