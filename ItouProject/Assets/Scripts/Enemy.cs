using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Data data;
    
    public void Response(char lastword)
    {
        string[] seachWord = data.sound50Index[lastword.ToString()];
        //int num = Random.Range(0, seachWord.Count - 1);
        // string res = seachWord[num];
    }

    public void Response()
    {
        int temp = Random.Range(0, data.data.Count - 1);
        string res = data.data[temp];
        Debug.Log(res);
    }
}
