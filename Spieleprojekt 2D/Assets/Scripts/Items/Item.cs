using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Item : MonoBehaviour
{


    [SerializeField] private GameObject ItemCanvas;
    [SerializeField] private GameObject EgO;

    private int index = 0;
    private bool nowSwitch = false;

    private bool inRange = false;

    public static bool isActive = false;
    private void Start()
    {
        EgO.SetActive(false);
    }

    private void Update()
    {
        if(inRange)
        {
            if ( Input.GetKeyDown(KeyCode.E) && index == 0 && nowSwitch == false)
            {
                nowSwitch = true;
                index = 1;
                ItemCanvas.SetActive(true);
                PlayerController.isPlayerFrozen = true;
                isActive = true;
            }

            if (Input.GetKeyDown(KeyCode.E) && index == 1 && nowSwitch == false)
            {
                index = 0;
                ItemCanvas.SetActive(false);
                PlayerController.isPlayerFrozen = false;
                isActive = true;
            }

            nowSwitch = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            EgO.SetActive(true);
            inRange = true;
        }

       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            EgO.SetActive(false);
            inRange = false;
        }
    }
}
