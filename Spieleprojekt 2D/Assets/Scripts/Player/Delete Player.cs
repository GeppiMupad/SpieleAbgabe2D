using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePlayer : MonoBehaviour
{
   
    private void Awake()
    {
        if(Door.hasChanges == true)
        {
           // MainSpawngO.SetActive(false);
            // Destroy(GameObject.FindWithTag("Player"));
           // GameObject tempgO = GameObject.FindWithTag("Player");
           //tempgO.SetActive(false);
        }

    }
}
