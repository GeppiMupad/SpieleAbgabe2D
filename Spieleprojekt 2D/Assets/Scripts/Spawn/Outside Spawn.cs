using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.XR;
using UnityEngine;

public class SpawnPlayerOutside : MonoBehaviour
{
    [SerializeField] private GameObject PlayergO;
    [SerializeField] private GameObject SpawnergO;
    [SerializeField] private int spawnIndex;

    private static int index = 0; // index specified to each spawn, if index = 1 , then spawn 1 spawns the player 

    void Start()
    {
       
        Debug.Log("Start wurde ausgeführt " + index);
        if (MainSpawn.firstSpawn == false && index == spawnIndex )
        {
            Instantiate(PlayergO, transform.position, Quaternion.identity);
        }
    }
    //DoortoOutside.SpawnOutside += SpawnPlayer; //  This Event destroys the object ( whatever ) 
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            for (int i = 0; i <= spawnIndex; i++)
            {
                if(i == spawnIndex)
                {
                    index = i;
                }
            }
            
            Debug.Log(index);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           
        }
    }
}

 
        

