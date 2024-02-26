using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideSpawn : MonoBehaviour
{
    [SerializeField] private GameObject PlayergO;
    [SerializeField] private GameObject SpawngO;
    void Start()
    {
        
        Instantiate(PlayergO, SpawngO.transform.position, Quaternion.identity);
    }


}
