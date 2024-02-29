using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSpawn : MonoBehaviour
{
    public delegate void PlayerCam();
    public static event PlayerCam CameraEvent;

    [SerializeField] private GameObject PlayerObject;
    public static GameObject playerToFollowObject;
    public static bool firstSpawn = true;

  
    void Start()
    {
        if(firstSpawn == true)
        {

            playerToFollowObject = Instantiate(PlayerObject,transform.position, Quaternion.identity);
            
        }
        CameraEvent?.Invoke();

    }

 
}
