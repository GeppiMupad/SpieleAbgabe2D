using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    [SerializeField] private GameObject WarninggO;
    public static bool allCorrect = false;

    public void OnClickYes()
    {
        if(allCorrect == true)
        {
            Debug.Log("Du hast es geschafft");
           // SceneManager.LoadScene("WinnerScene");
        }
        if(allCorrect == false)
        {
            Debug.Log("Du hast es leider nicht geschafft");
            // SceneManager.LoadScene("LooserScene");
        }
    }

    public void OnClickNo()
    {
        WarninggO.SetActive(false);
    }
}
