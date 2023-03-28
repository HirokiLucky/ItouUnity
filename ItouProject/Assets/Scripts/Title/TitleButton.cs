using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButton : MonoBehaviour
{
    public void OnClickSingle()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OnClickMulti()
    {
        Debug.Log("未実装");
    }

    public void OnClickHowToPlay()
    {
        Debug.Log("a");
    }
}
