using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public void RightButton()
    {
        // change prepetrator index
        if (Investigationfile.prepetratorIndex < 4)
            Investigationfile.prepetratorIndex++;
        else
            Investigationfile.prepetratorIndex = 0;
    }

    public void LeftButton()
    {
        // change prepetrator index
        if(Investigationfile.prepetratorIndex > 0)
        Investigationfile.prepetratorIndex--;
        else
            Investigationfile.prepetratorIndex = 4;
    }
}
