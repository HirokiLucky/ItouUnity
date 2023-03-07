using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

// 敵の動きに関するスクリプト
public class Enemy : MonoBehaviour
{
    [SerializeField] private Data data;

    [SerializeField] private GameSystem _gameSystem;
    [SerializeField] private AttackEffects _attackEffects;

    [SerializeField] private Text returnText;
    
    // 6番目
    public void Response(char lastword, int wordCount)
    {
        StartCoroutine(ThinkingTimeNormal(lastword, wordCount));
    }

    // 7番目
    // 敵の動き
    // Easy
    IEnumerator ThinkingTime(char lastword, int wordCount)
    {
        // 考えている様に見せる時間　７～９秒
        int rest = Random.Range(7, 10);
        yield return　new WaitForSeconds(rest);
        
        // 単語選択
        string[] seachWord = data.sound50Index[lastword.ToString()][wordCount - 2]; // プレイヤーの単語数と同じ（オウム返し）
        int num = Random.Range(0, seachWord.Length - 1);
        string res = seachWord[num];
        returnText.text = res;
        _gameSystem.ReturnText();
        Debug.Log(res);
        
        // ReturnText 表示時間
        yield return　new WaitForSeconds(3);

        bool lastWordJudge = _gameSystem.AddWordListEnemy(res);
        
        if(lastWordJudge)_attackEffects.Attack(wordCount);
    }
    
    // Normal
    IEnumerator ThinkingTimeNormal(char lastword, int wordCount)
    {
        int rest = Random.Range(7, 10);
        yield return　new WaitForSeconds(rest);
        
        string res;
        string[] seachWord = data.sound50Index[lastword.ToString()][Random.Range(0, 7)]; // ランダムな単語数
        do
        {
            int num = Random.Range(0, seachWord.Length - 1);
            res = seachWord[num];
            returnText.text = res;
            _gameSystem.ReturnText();
            Debug.Log(res);
        } while (res.LastOrDefault() == 'ん');
        
        
        yield return　new WaitForSeconds(3);

        bool lastWordJudge = _gameSystem.AddWordListEnemy(res);
        
        if(lastWordJudge)_attackEffects.Attack(res.Length);
    }
    
}
