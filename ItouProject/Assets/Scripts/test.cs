using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;

public class test : MonoBehaviour
{
    [SerializeField]
    private Button m_speechToTextButton = default;

    private DictationRecognizer m_DictationRecognizer;

    void InitDictationRecognizer()
    {
        m_DictationRecognizer = new DictationRecognizer();

        m_DictationRecognizer.DictationResult += OnFinishSpeechToTextButton;

        m_DictationRecognizer.DictationComplete += (completionCause) =>
        {
            if (completionCause != DictationCompletionCause.Complete)
                Debug.LogErrorFormat("Dictation completed unsuccessfully: {0}.", completionCause);
        };

        m_DictationRecognizer.DictationError += (error, hresult) =>
        {
            Debug.LogErrorFormat("Dictation error: {0}; HResult = {1}.", error, hresult);
        };
    }
    public void OnClickSpeechToTextButton()
    {
        Debug.Log("a");
        InitDictationRecognizer();
        m_DictationRecognizer.Start();
        m_speechToTextButton.interactable = false;
    }
    void OnFinishSpeechToTextButton(string text, ConfidenceLevel confidence)
    {
        Debug.LogFormat("Dictation result: {0}", text);
        m_DictationRecognizer.Stop();
        m_DictationRecognizer.Dispose();
        m_speechToTextButton.interactable = true;
    }
}
