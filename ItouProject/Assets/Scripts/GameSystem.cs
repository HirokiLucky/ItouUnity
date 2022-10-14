using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    private List<string> wordList = new List<string>();
    private char lastWord = 'り';
    [SerializeField] private TextMeshProUGUI lastWordUI;

    public void AddWordList(string addWord)
    {
        if (wordList.Contains(addWord))
        {
            Debug.Log("既に言われた言葉です");
        }else if (lastWord != addWord.FirstOrDefault()) {
            Debug.Log("「"+ lastWord + "」から始まっていません");
        }else
        {
            wordList.Add(addWord);
            Debug.Log(wordList.Count);

            lastWord = addWord.LastOrDefault();
            lastWordUI.text = "「" + lastWord + "」から始まる";
        }
    }
}
