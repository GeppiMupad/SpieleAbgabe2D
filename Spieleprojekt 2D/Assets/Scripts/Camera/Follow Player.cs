using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
   
    [SerializeField] private Transform player;
    private GameObject PlayergO;

    private bool hasFound = false;

    private void Start()
    {
        MainSpawn.CameraEvent += FindPlayer;
        DoortoOutside.SetBotTrue += FindPlayer;
    }
    void Update()
    {
        if(hasFound == true)
        {
            Vector3 newPos = new Vector3(PlayergO.transform.position.x, PlayergO.transform.position.y, -10f);
            transform.position = Vector3.Slerp(transform.position, newPos, speed * Time.deltaTime);
        }
       
    }

    private void FindPlayer()
    {
        if (GameObject.FindWithTag("Player"))
        {
            
            PlayergO = GameObject.FindWithTag("Player");
            PlayergO.SetActive(true);
            hasFound = true;
        }
    }

 
}
