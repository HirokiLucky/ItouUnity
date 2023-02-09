using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;

public class Listenner : MonoBehaviour
{
    // 認識開始ボタン
    [SerializeField] private Button m_speechToTextButton = default;

    // レコグナイザー
    private KeywordRecognizer m_Recognizer;
    
    // キーワード単語集
    [SerializeField] private string[] m_Keywords;

    // 返ってきた文字列
    public Text ReturnText;
    
    [SerializeField] private GameSystem _gameSystem;

    [SerializeField] private Data _data;
    [SerializeField] private AttackEffects _attackEffects;

    private char lastWordSave = 'あ';
    public int wordCount = 2;

    [SerializeField] private GameObject magicButton;
    [SerializeField] private GameObject stopButton;

    private void Start()
    {
        m_Keywords = _data.sound50Index[_gameSystem.lastWord.ToString()][wordCount - 2];
        m_Recognizer = new KeywordRecognizer(m_Keywords);
        m_Recognizer.OnPhraseRecognized += OnPhraseRecognized;
    }


    // 3番目
    public void OnClickSpeechToTextButton()
    {
        Debug.Log("認識開始");
        if (lastWordSave != _gameSystem.lastWord)
        {
            m_Keywords = _data.sound50Index[_gameSystem.lastWord.ToString()][wordCount - 2];
            lastWordSave = _gameSystem.lastWord;
            m_Recognizer = new KeywordRecognizer(m_Keywords);
            m_Recognizer.OnPhraseRecognized += OnPhraseRecognized;
        }
        m_Recognizer.Start();
        m_speechToTextButton.interactable = false;
    }
    
    // 4番目
    private void OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendFormat("{0} ({1}){2}", args.text, args.confidence, Environment.NewLine);
        builder.AppendFormat("\tTimestamp: {0}{1}", args.phraseStartTime, Environment.NewLine);
        builder.AppendFormat("\tDuration: {0} seconds{1}", args.phraseDuration.TotalSeconds, Environment.NewLine);
        Debug.Log(builder.ToString());
        
        bool lastWordJudge = _gameSystem.AddWordList(args.text);
        ReturnText.text = args.text;
        _gameSystem.ReturnText();
        wordCount = args.text.Length - 2;
        m_Recognizer.Stop();
        m_Recognizer.Dispose();
        _gameSystem.StopCoroutine("Timer");
        magicButton.SetActive(false);
        stopButton.SetActive(false);
        m_speechToTextButton.interactable = true;
        Destroy(_gameSystem.clickedGameObject_save);
        if(lastWordJudge) _attackEffects.Attack(_gameSystem.lastWord, args.text.Length);
    }

    public void OnClickStop()
    {
        m_Recognizer.Stop();
        m_Recognizer.Dispose();
        m_speechToTextButton.interactable = true;
        Debug.Log("音声認識を停止しました。");
    } 
}
