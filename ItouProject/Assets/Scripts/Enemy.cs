using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Data data;

    [SerializeField] private GameSystem _gameSystem;
    
    public void Response(char lastword)
    {
        StartCoroutine("ThinkingTime");
        string[] seachWord = data.sound50Index[lastword.ToString()];
        int num = Random.Range(0, seachWord.Length - 1);
        string res = seachWord[num];
        Debug.Log(res);
        
        _gameSystem.AddWordListEnemy(res);
    }

    public void Response()
    {
        int temp = Random.Range(0, data.data.Count - 1);
        string res = data.data[temp];
        Debug.Log(res);
    }

    IEnumerator ThinkingTime()
    {
        int num = Random.Range(1, 7);
        yield return　new WaitForSeconds(num);
    }
}
