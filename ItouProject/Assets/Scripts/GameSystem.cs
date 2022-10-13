using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    private List<string> wordList = new List<string>();

    public void AddWordList(string addWord)
    {
        if (wordList.Contains(addWord))
        {
            Debug.Log("既に言われた言葉です");
        }
        else
        {
            wordList.Add(addWord);
            Debug.Log(wordList.Count);
        }
    }
}
