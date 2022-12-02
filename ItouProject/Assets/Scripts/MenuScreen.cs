using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using Sequence = DG.Tweening.Sequence;

public class MenuScreen : MonoBehaviour
{
    [SerializeField] private DOMenuScreen _doMenuScreen;
    [SerializeField] private RectTransform attentionScreen;
    public void OnClickBack()
    {
        _doMenuScreen.spread = false;
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(gameObject.GetComponent<RectTransform>().DOAnchorPos(new Vector2(350, 150), 0.5f)).SetEase(Ease.InSine)
            .Join(gameObject.GetComponent<RectTransform>().DOScale(new Vector3(0, 0, 0), 0.5f));
    }

    public void OnClickHoge()
    {
        Debug.Log("未実装");
    }

    public void OnClickExit()
    {
        attentionScreen.DOScale(new Vector3(1, 1, 1), 0.5f);
    }

    public void OnClickYes()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void OnClickNo()
    {
        attentionScreen.DOScale(new Vector3(0, 0, 0), 0.5f);
    }
}
