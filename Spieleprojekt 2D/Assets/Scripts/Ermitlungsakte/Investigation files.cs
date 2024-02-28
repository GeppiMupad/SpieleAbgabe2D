using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Investigationfiles : MonoBehaviour
{
    [SerializeField] private GameObject InvestigationgO;
    private void Awake()
    {
        DontDestroyOnLoad(InvestigationgO);
        
    }
    private void Start()
    {
       // InvestigationgO.SetActive(true);
    }
}
