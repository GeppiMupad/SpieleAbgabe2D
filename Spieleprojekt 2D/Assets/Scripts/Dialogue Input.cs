using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DialogueInput : MonoBehaviour
{
    public delegate void ShowQuestionCanvas();
    public static event ShowQuestionCanvas QuestionEvent;


    //For Text Animation
    [SerializeField] private int letterPerSeconds;
    [SerializeField] private TextMeshProUGUI m_text; // the answers, the bot is giving 



    [SerializeField] string beginningSentence;
    
    [SerializeField] private string[] answersA = new string[3];

    public static int i = 0;   // index , which button got pressed ( button returns i value )

    public static bool repeat = false;
    

    public void Start()
    {
        StartCoroutine(Dialogue(beginningSentence));
        
    }

    private void Repeat()
    {
        StartCoroutine(Dialogue(beginningSentence)); //everytime we start convo with bot, he starts with his first sentence
        repeat = false;
    }

    public void Update()
    {
        #region PrintAnswers

        if(repeat) //is true in Bot Dialogue
        {
            Repeat();
        }


        if (i == 1)
        {
            StartCoroutine(Dialogue(answersA[0]));
            i = 0;
        }
        if (i == 2)
        {
            StartCoroutine(Dialogue(answersA[1]));
            i = 0;
        }
        if (i == 3)
        {
            StartCoroutine(Dialogue(answersA[2]));
            i = 0;
        }
        #endregion


    }



    /// <summary>
    /// makes an animation of ur parameter dialogue
    /// </summary>
    /// <param name="dialogue"></param>
    /// <returns></returns>
    public IEnumerator Dialogue(string dialogue)
    {
        
        m_text.text = "";
        foreach (var letter in dialogue.ToCharArray())
        {
            m_text.text += letter;
            yield return new WaitForSeconds(2f / letterPerSeconds);
        }
        BotDialogue.DialogueAudio.Stop();
        QuestionEvent?.Invoke();
    }
}
