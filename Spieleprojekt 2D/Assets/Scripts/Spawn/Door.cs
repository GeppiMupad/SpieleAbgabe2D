using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public delegate void FindBot();
    public static event FindBot SetBotFalse;

    public static bool hasChanges = false; // loaded a new scene , if so -> true -> DeletePlayer Deletes starting player -> cause player not a prefab
    [SerializeField] private string LoadScene;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            GameObject tempgO = GameObject.FindWithTag("Player");
            tempgO.SetActive(false);
            MainSpawn.firstSpawn = false;
            SceneManager.LoadScene($"{LoadScene}");
            hasChanges = true;

            SetBotFalse?.Invoke();
        }
    }


}
