using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.XR;
using UnityEngine;

public class SpawnPlayerOutside : MonoBehaviour
{
    [SerializeField] private GameObject PlayerObject;
    [SerializeField] private GameObject SpawnerObject;

    private int index = 0;

  // index wird ja mit scenenwechsel wieder auf 0 zurückgesetzet

    private void Awake()
    {

    }

    void Start()
    {
       
        Debug.Log("Start wurde ausgeführt " + index);
        if (MainSpawn.firstSpawn == false )
        {
            Instantiate(PlayerObject, transform.position, Quaternion.identity);
        }
    }
    //DoortoOutside.SpawnOutside += SpawnPlayer; // das Event zerstört warum auch immer das Object
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            index++;
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

 
        

