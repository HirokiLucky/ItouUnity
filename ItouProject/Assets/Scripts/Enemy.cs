using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Data data;

    [SerializeField] private GameSystem _gameSystem;
    [SerializeField] private AttackEffects _attackEffects;

    [SerializeField] private Text returnText;
    
    // 6番目
    public void Response(char lastword, int wordCount)
    {
        StartCoroutine(ThinkingTime(lastword, wordCount));
    }

    // 7番目
    // 敵の動き
    IEnumerator ThinkingTime(char lastword, int wordCount)
    {
        int rest = Random.Range(7, 10);
        yield return　new WaitForSeconds(rest);
        
        string[] seachWord = data.sound50Index[lastword.ToString()][wordCount - 2];
        int num = Random.Range(0, seachWord.Length - 1);
        string res = seachWord[num];
        returnText.text = res;
        _gameSystem.ReturnText();
        Debug.Log(res);
        
        yield return　new WaitForSeconds(3);

        bool lastWordJudge = _gameSystem.AddWordListEnemy(res);
        
        if(lastWordJudge)_attackEffects.Attack(wordCount);
    }
}
