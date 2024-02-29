using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoortoOutside : MonoBehaviour
{
    public delegate void FindBot();
    public static event FindBot SetBotTrue;


    public static event Action SpawnOutside; // unnötig 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject tempgO = GameObject.FindWithTag("Player");
            tempgO.SetActive(true);
            SetBotTrue?.Invoke();
            SceneManager.LoadScene("SampleScene");
            
           // SpawnOutside?.Invoke();
            
   
        }
    }
}
