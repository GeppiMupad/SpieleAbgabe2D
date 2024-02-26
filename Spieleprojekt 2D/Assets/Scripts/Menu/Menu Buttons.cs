using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void StartButton()
    {
        Debug.Log("Start Game");
       // SceneManager.LoadScene("Game");
    }

    public void TutorialButton()
    {
        Debug.Log("Tutorial Start");
       // SceneManager.LoadScene("Tutorial");
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
