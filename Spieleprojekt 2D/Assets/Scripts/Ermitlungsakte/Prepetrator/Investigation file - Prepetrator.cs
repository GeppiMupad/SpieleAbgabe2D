using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Investigationfile : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI PrepetratorText;

    public static int prepetratorIndex = 0;

    private string[] perpetratorA = new string[]
    {
        "Niemand",
        "Justus von Bürckelstedt",
        "Joshua Bast",
        "Dr. Phillip",
        "Julia Brochmayer"

    };


    private void FixedUpdate()
    {
        PrepetratorText.text = perpetratorA[prepetratorIndex];  // shows prepetrator 

        
    }
}
