using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindBot : MonoBehaviour
{

    void Start()
    {
        Door.SetBotFalse += SetBotFalse;

        DoortoOutside.SetBotTrue += SetBotTrue;
    }


    private void SetBotFalse()
    {
        foreach (GameObject item in GameObject.FindGameObjectsWithTag("Bot"))
        {
            item.transform.localScale = new Vector3(0, 0, 0);
        }
    }

    private void SetBotTrue()
    {
        foreach (GameObject item in GameObject.FindGameObjectsWithTag("Bot"))
        {
            item.transform.localScale = new Vector3(6, 6, 0);
        }
    }

}
