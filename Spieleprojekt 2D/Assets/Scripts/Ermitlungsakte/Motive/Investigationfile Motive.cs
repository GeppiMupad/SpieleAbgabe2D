using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InvestigationfileMotive : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI MotiveText;

    public static int motiveIndex = 0;

    private string[] motiveA = new string[]
{
        "Keins",
        "Geld",
        "Rache",
        "Eifersucht",
        "Erbe"

};


    private void FixedUpdate()
    {   
        MotiveText.text = motiveA[motiveIndex]; // shows motive
                                               
        
    }
}
