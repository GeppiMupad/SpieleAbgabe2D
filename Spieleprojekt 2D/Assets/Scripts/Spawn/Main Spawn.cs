using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSpawn : MonoBehaviour
{
    [SerializeField] private GameObject PlayerObject;
    public static GameObject playerToFollowObject;
    public static bool firstSpawn = true;

  
    void Start()
    {
        if(firstSpawn == true)
        {

            playerToFollowObject = Instantiate(PlayerObject,transform.position, Quaternion.identity);
            
        }
    }

 
}
