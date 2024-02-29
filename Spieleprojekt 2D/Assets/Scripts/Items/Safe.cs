using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;
using static UnityEditor.Progress;

public class Safe : MonoBehaviour
{

     // hätte buttons anders regeln können durch Parameter. Parameter kann man im Inspector anpassen = bräuchte nur eine Methode statt 9
    [SerializeField] private TextMeshProUGUI InputText;

  //  private int inputIndex = 0;

    private string[] inputA = new string[]
     {
        "0",
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9"
        

       };

    private static List<int> solutionL = new List<int>();

    
    private void PrintInput(int _input)
    {
            InputText.text += inputA[_input];
            solutionL.Add(_input);
    }

        
    public void Delete()
    {    
        string temp = "";
        InputText.text = temp;
        solutionL.Clear();
    }

    public void Check()
    {
 
        if (solutionL[0] == 1 && solutionL[1] == 9 && solutionL[2] == 7 && solutionL[3] == 2 )
        {
            Debug.Log("Safe ist auf");
        }
        else
        {
            Debug.Log("Falscher Code");           
        }
    }
    public void Zero()
    {
        PrintInput(0);       
    }
    public void One()
    {
        PrintInput(1); 
    }

    public void Two()
    {
        PrintInput(2); 
    }

    public void Three()
    {
        PrintInput(3);
    }
    public void Four()
    {
        PrintInput(4); 
    }
    public void Five()
    {
        PrintInput(5); 
    }
    public void Six()
    {
        PrintInput(6); 
    }
    public void Seven()
    {
        PrintInput(7); 
    }
    public void Eight()
    {
        PrintInput(8); 
    }

    public void Nine()
    {
        PrintInput(9); 
    }
}
