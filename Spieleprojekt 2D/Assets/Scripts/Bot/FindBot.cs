using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindBot : MonoBehaviour
{

    void Start()
    {
        Door.SetBotFalse += SetBotInvisible;

        DoortoOutside.SetBotTrue += SetBotVisible;
    }

    /// <summary>
    /// Set Bot "Invisible"
    /// </summary>
    private void SetBotInvisible()
    {
        foreach (GameObject item in GameObject.FindGameObjectsWithTag("Bot"))
        {
            item.transform.localScale = new Vector3(0, 0, 0);
        }
    }

    /// <summary>
    /// Set Bot "Visible"
    /// </summary>
    private void SetBotVisible()
    {
        foreach (GameObject item in GameObject.FindGameObjectsWithTag("Bot"))
        {
            item.transform.localScale = new Vector3(6, 6, 0);
        }
    }

}
