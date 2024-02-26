using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotSpawner : MonoBehaviour
{
    [SerializeField] private GameObject BotgO;
  

    [SerializeField] private string getTagToCompare;

 

    void Update()
    {

        if(GameObject.FindWithTag(getTagToCompare))
        {
            Destroy(BotgO);
        }   
    }
}
