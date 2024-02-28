using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;

public class Safe : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI InputText;

    private TextMeshProUGUI EmptyText = null;
    private int inputIndex = 0;

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

    private List<int> solutionA = new List<int>();


    private void PrintInput(int _input)
    {
        if(inputIndex < 4)
        {
            InputText.text += inputA[_input];
            solutionA.Add(_input);

        }
       
    }

        
    public void Delete()
    {
        InputText.text = EmptyText.text;
    }

    public void Check()
    {

        foreach (var item in solutionA)
        {
            Debug.Log(item);
        }
       /* if (solutionA[0] == 1 && solutionA[1] == 9 && solutionA[2] == 7 && solutionA[3] == 2 )
        {
            Debug.Log("Safe ist auf");
        }
        else
        {
            Debug.Log("Falscher Code");
            InputText.text = EmptyText.text;
        }*/

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
        PrintInput(3);;
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
