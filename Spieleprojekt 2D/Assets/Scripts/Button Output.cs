using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public delegate void ShowCanvas();
    public static event ShowCanvas Managecanvas;   // Event in Bot Dialogue

    public delegate void ExitButton();
    public static event ExitButton OnClickExit;   // Event in Bot Dialogue
    public void ButtonOne()
    {
        DialogueInput.i = 1;
       
        Managecanvas?.Invoke();
    }

    public void ButtonTwo()
    {
        DialogueInput.i = 2;
      
        Managecanvas?.Invoke();    
    }

    public void ButtonThree()
    {
        DialogueInput.i = 3;
       
        Managecanvas?.Invoke();   
    }


    public void ButtonExit()
    {
       BotDialogue.exitButton = true;

        OnClickExit?.Invoke();      
    }
}
