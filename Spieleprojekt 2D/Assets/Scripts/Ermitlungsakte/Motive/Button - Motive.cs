using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMotive : MonoBehaviour
{
    public void RightButton()
    {
        // change motive index
        if (InvestigationfileMotive.motiveIndex < 4)
            InvestigationfileMotive.motiveIndex++;
        else
            InvestigationfileMotive.motiveIndex = 0;
    }

    public void LeftButton()
    {
        
        // change motive index
        if (InvestigationfileMotive.motiveIndex > 0)
            InvestigationfileMotive.motiveIndex--;
        else
            InvestigationfileMotive.motiveIndex = 4;
    }
}
