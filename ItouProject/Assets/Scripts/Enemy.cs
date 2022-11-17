using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Data data;

    [SerializeField] private GameSystem _gameSystem;
    [SerializeField] private AttackEffects _attackEffects;
    
    // 6番目
    public void Response(char lastword)
    {
        StartCoroutine("ThinkingTime", lastword);
    }

    // 7番目
    IEnumerator ThinkingTime(char lastword)
    {
        int rest = Random.Range(7, 10);
        yield return　new WaitForSeconds(rest);
        
        string[] seachWord = data.sound50Index[lastword.ToString()];
        int num = Random.Range(0, seachWord.Length - 1);
        string res = seachWord[num];
        Debug.Log(res);
        
        _gameSystem.AddWordListEnemy(res);
        
        _attackEffects.Attack();
    }
}
