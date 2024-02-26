using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public delegate void FindBot();
    public static event FindBot SetBotFalse;
    

    [SerializeField] private string LoadScene;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(GameObject.FindWithTag("Player"));
            MainSpawn.firstSpawn = false;
            SceneManager.LoadScene($"{LoadScene}");

            SetBotFalse?.Invoke();
        }
    }


}
