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
    public TextMeshProUGUI ReturnText;
    
    [SerializeField] private GameSystem _gameSystem;

    [SerializeField] private Data _data;

    private char lastWordSave = 'り';

    private void Start()
    {
        m_Keywords = _data.sound50Index[_gameSystem.lastWord.ToString()];
        m_Recognizer = new KeywordRecognizer(m_Keywords);
        m_Recognizer.OnPhraseRecognized += OnPhraseRecognized;
    }


    public void OnClickSpeechToTextButton()
    {
        Debug.Log("認識開始");
        if (lastWordSave != _gameSystem.lastWord)
        {
            m_Keywords = _data.sound50Index[_gameSystem.lastWord.ToString()];
            lastWordSave = _gameSystem.lastWord;
            m_Recognizer = new KeywordRecognizer(m_Keywords);
            m_Recognizer.OnPhraseRecognized += OnPhraseRecognized;
        }
        m_Recognizer.Start();
        m_speechToTextButton.interactable = false;
    }
    private void OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendFormat("{0} ({1}){2}", args.text, args.confidence, Environment.NewLine);
        builder.AppendFormat("\tTimestamp: {0}{1}", args.phraseStartTime, Environment.NewLine);
        builder.AppendFormat("\tDuration: {0} seconds{1}", args.phraseDuration.TotalSeconds, Environment.NewLine);
        Debug.Log(builder.ToString());
        
        _gameSystem.AddWordList(args.text);
        ReturnText.text = args.text;
        m_Recognizer.Stop();
        m_Recognizer.Dispose();
        m_speechToTextButton.interactable = true;
    }

    public void OnClickStop()
    {
        m_Recognizer.Stop();
        m_Recognizer.Dispose();
        m_speechToTextButton.interactable = true;
        Debug.Log("音声認識を停止しました。");
    } 
}
